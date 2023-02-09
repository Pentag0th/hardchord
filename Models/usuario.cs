using System.ComponentModel.DataAnnotations;

namespace Hardchord.Models

{

    public class Usuarios
    {
        [Key]
        public int idUsers { get; set; }
        [Required]
        public string usersName { get; set; }
        [Required]
        public string password { get; set; }


    }
}