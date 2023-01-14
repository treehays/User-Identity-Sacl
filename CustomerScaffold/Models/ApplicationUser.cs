using Microsoft.AspNetCore.Identity;
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
        public byte[] ProfilePicture { get; set; }
    }
}
