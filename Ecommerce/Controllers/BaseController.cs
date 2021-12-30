using Ecommerce.API.Models;
using Ecommerce.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ecommerce.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        protected readonly INotification Notification;

        public BaseController(INotification notification)
        {
            Notification = notification;
        }

        protected IActionResult CreateResponse(object data)
        {
            HttpStatusCode statusCode = IsOperationValid() ? HttpStatusCode.OK : HttpStatusCode.BadRequest;

            return this.CreateResponse(data, statusCode);
        }

        protected IActionResult CreateResponse(object data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            bool success = IsOperationValid();

            DefaultApiResponse<object> response = new()
            {
                Success = success,
                Response = data,
                Messages = Notification.Notifications.ToList()
            };

            if (!success)
            {
                if (statusCode == HttpStatusCode.OK) statusCode = HttpStatusCode.BadRequest;

                return StatusCode((int)statusCode, response);
            }

            return new ObjectResult(response) { StatusCode = (int)statusCode };
        }

        protected bool IsOperationValid() => !Notification.HasNotification();

    }
}
