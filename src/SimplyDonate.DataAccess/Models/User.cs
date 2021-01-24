using System.ComponentModel.DataAnnotations;

namespace SimplyDonate.DataAccess
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
