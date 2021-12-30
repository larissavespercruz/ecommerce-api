using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DateRegister { get; set; }
        public bool IsFinished { get; set; }
        public byte[] Image { get; set; }
    }
}
