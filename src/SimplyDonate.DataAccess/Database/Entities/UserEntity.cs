using System.ComponentModel.DataAnnotations;

namespace SimplyDonate.DataAccess.Database.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
