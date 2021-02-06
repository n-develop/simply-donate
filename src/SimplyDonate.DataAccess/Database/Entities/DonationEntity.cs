using System.ComponentModel.DataAnnotations;

namespace SimplyDonate.DataAccess.Database.Entities
{
    public class DonationEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }
        //TODO images
    }
}