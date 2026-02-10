using Microsoft.AspNetCore.Identity;

namespace MyMvcAuthProject.Models
{
    public class MyApplicationUser : IdentityUser
    {
        public string? City { get; set; }
        public string? State { get; set; }
    }
}
