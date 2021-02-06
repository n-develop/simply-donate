using System.ComponentModel.DataAnnotations;

namespace SimplyDonate.DataAccess.Database.Entities
{
    public class DonationCategoryEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        // TODO Sub categories
    }
}