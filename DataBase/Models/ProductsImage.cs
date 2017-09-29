using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
 
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum ImageType
    {
        Png,
        Xpng,
        Gif,
        Jpg,
        Jpeg,
        None,
    }

    public class ProductsImage
    {
        [Key]
        [ForeignKey("Products")]
        public int ProductsId { get; set; }

        public Products Products { get; set; }

        public byte[] Image { get; set; }

        public ImageType ImageType { get; set; }
    }
}
