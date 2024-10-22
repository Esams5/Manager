using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "username is required")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters") ]
        [MaxLength(80, ErrorMessage = "Username must be less than 80 characters")]
        
        public string Name { get; set; }
        
        [Required(ErrorMessage = "email is required")]
        [MinLength(3, ErrorMessage = "Email must be at least 3 characters")]
        [MaxLength(180, ErrorMessage = "Email must be less than 180 characters")]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")] //Validação básica
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")] // Validação mais robusta com mais casos
        
        

        public string Email { get;  set; }
        
        [Required(ErrorMessage = "password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        [MaxLength(30, ErrorMessage = "Password must be less than 30 characters")]
        
        
        
        

        public string Password { get;  set; }
    
    }
}

