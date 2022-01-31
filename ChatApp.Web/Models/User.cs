using System.ComponentModel.DataAnnotations;

namespace ChatApp.Web.Models;

public class User
{
    [Required(ErrorMessage = "Musisz wypełnić")]
    [MinLength(3, ErrorMessage = "Login jest za krótki")]
    public string Login { get; set; }
}