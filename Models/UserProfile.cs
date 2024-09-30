using System.ComponentModel.DataAnnotations;

namespace ExpenseManagement.Models
{
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }




        [Required(ErrorMessage = "Please Enter Your First name")]
        [MinLength(3, ErrorMessage = "First name  is TOO SHORT")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please Enter Your Last name")]
        [MinLength(3, ErrorMessage = "Last name is TOO SHORT")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
    }
}