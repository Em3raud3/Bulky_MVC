using System;
using System.Collections.Generic;
using System.Text;

namespace Bulky.Models.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ShoppingCartsList { get; set; }
        public double CartTotal { get; set; }
    }
}
