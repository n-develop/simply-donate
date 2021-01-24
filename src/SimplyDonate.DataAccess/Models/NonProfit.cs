using System.ComponentModel.DataAnnotations;

namespace SimplyDonate.DataAccess
{
    public class NonProfit
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        public string Description { get; set; }
        
        public string Address { get; set; }
        
        // TODO images
    }
}