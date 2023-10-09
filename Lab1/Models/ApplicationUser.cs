using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab1.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of birth")]
        [AllowNull]
        public DateTime? Birthday { get; set; }
    }
}
