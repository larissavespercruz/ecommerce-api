using Ecommerce.Domain.Models;

namespace Ecommerce.API.Models
{
    public class DefaultApiResponse<T>
    {
        public bool Success { get; set; }
        public T Response { get; set; }
        public ErrorDetails Error { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
    }
}
