using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppE.Models
{
   
    public class Cart
    {

        public Cart()
        {
            CartItems = new List<CartItem>();
        }


        public List<CartItem> CartItems { get; set; }

    }
}
