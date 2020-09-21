using AspNetCore.Identity.DocumentDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test42.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : DocumentDbIdentityUser<DocumentDbIdentityRole>
    {
    }
}
