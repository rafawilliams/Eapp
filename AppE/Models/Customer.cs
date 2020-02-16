using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppE.Models
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            CartItems = new HashSet<CartItem>();
            Orderes = new HashSet<Order>();

        }

        [ScaffoldColumn(false)]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "customer Name is required")]
        public string CustomerName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public int City { get; set; }

        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [EmailAddress, DataType(DataType.EmailAddress)]
        public string EmailAdress { get; set; }

        public DateTime? DateEntered { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

        public virtual ICollection<Order> Orderes { get; set; }


    }
}
