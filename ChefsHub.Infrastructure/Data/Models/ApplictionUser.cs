using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static ChefsHub.Infrastructure.Constants.DataConstants;

namespace ChefsHub.Infrastructure.Data.Models
{
    [Comment("Application user data")]
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(ApplicationUserFirstNameMaxLength)]
        [Comment("Application first name")]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(ApplicationUserLastNameMaxLength)]
        [Comment("Application last name")]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

        

    }
}
