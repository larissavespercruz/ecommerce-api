using Microsoft.AspNetCore.Mvc;
using Ecommerce.Domain.ViewModels;
using Ecommerce.Domain.IRepository;
using System.Net;
using Ecommerce.Domain.Contracts;

namespace Ecommerce.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : BaseController
    {
        private IProductRepository _productRepository;
        private readonly INotification _notification;
        public ProductController(IProductRepository productRepository, INotification notification) : base(notification)
        {
            _productRepository = productRepository;
            _notification = notification;
        }

        public async Task<IList<ProductViewModel>> GetProduct()
        {
            return (IList<ProductViewModel>)CreateResponse(null, HttpStatusCode.OK);
        }
    }
}
