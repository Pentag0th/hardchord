
using System.ComponentModel.DataAnnotations;

namespace Hardchord.Models

{

    public class orders 
    {
        [Key]
        public int orderID { get; set; }
        [Required]
        public string userID { get; set; }
        [Required]
        public double totalPrice { get; set; }
      
        [Required]
        public System.Collections.Generic.IEnumerable<Prodcutos> ProdcutosList { get; set; }

    }}