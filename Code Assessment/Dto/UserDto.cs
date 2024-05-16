using System.ComponentModel.DataAnnotations;

namespace Code_Assessment.Dto
{
    public class UserDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }

    public class LogingRequesteModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your Email.")]
        [MinLength(5), MaxLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50, MinimumLength = 6), DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
