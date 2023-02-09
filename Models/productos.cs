using System.ComponentModel.DataAnnotations;

namespace Hardchord.Models

{

    public class Prodcutos
    {
        [Key]
        public int idProductos{ get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public double price { get; set; }
       


    }
}