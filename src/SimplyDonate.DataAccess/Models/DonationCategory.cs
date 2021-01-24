using System.ComponentModel.DataAnnotations;

namespace SimplyDonate.DataAccess
{
    public class DonationCategory
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        // TODO Sub categories
    }
}