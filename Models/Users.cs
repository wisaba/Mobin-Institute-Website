using Microsoft.AspNetCore.Identity;

namespace Mobin.Models
    
{
    public class Users : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
