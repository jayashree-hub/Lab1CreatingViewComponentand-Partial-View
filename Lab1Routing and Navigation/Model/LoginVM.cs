using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lab1Routing_and_Navigation.Model
{
    public class LoginVM
    {
        [Display (Name ="Email Address ")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string  Password { get; set; }
    }
}
