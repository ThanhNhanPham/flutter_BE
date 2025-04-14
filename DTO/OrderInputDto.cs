using System.ComponentModel.DataAnnotations;

namespace FoodOdering_BE.DTO
{
    public class OrderInputDto
    {
        [Required(ErrorMessage = "UserId is required")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "CartIds are required")]
        public List<int> CartIds { get; set; }
    }

}
