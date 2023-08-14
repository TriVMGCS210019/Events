using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Events.Models;

namespace Events.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        public string? Fullname { get; set; }
        [StringLength(10, ErrorMessage = "{0} lenghth must be exactly {1}",
            MinimumLength = 10)]
        public string? UCN { get; set; }
    }
}
