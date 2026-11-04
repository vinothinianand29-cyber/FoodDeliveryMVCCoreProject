using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryMVCCoreProject.Models
{
    public class FoodDetails
    {
        [Key]
        public Guid FoodId { get; set; }
      [Required]  public string? FoodName { get; set; }
        [Required] public string? Category { get; set; }

        [Required] public double Price { get; set; }

        public bool IsAvailable  { get; set; }


    }
}
