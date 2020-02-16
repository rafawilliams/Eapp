using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppE.Models
{
    [Table("Picture")]
    public class Picture
    {
        

        public int PictureId { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }


        //public virtual ICollection<Product> Products { get; set; }

    }
}