using System.ComponentModel.DataAnnotations;

namespace FoodOdering_BE.Model
{
    public class ChangePasswordModel
    {
        public string UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
    
}
