using Microsoft.AspNetCore.Identity;

namespace RockyStore_Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
