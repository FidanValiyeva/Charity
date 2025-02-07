using Microsoft.AspNetCore.Identity;

namespace Charity.Models
{
    public class User:IdentityUser
    {
        public string FullName { get; set; }
        public string ProfileImageUrl { get; set; }
    }
}
 