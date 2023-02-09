
using System.ComponentModel.DataAnnotations;

namespace Hardchord.Models

{

    public class ventas
    {
        [Key]
        public int ventasID { get; set; }
        [Required]
        public string userID { get; set; }
        [Required]
        public double totalPrice { get; set; }

        [Required]
        public System.Collections.Generic.IEnumerable<Prodcutos> ProdcutosList { get; set; }

    }
}