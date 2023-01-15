using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;


namespace CustomerScaffold.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[]? ProfilePicture { get; set; }
       /* [TempData]
        public string StatusMessage { get; set; }*/
/*        [TempData]
        public string UserNameChangeLimitMessage { get; set; }*/
        //[BindProperty]
        //public InputModel Input { get; set; }
    }
}
