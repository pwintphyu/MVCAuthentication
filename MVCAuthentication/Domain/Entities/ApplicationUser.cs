using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    //public class ApplicationUser : IdentityUser<int, UserLogin, UserRole, UserClaim>, Interfaces.IUser
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }
    //    public string JobTitle { get; set; }

    //    public int? DepartmentId { get; set; }

    //    public string DisplayName
    //    {
    //        get
    //        {
    //            return this.FirstName + ' ' + this.LastName;
    //        }
    //    }

    //    //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
    //    //{
    //    //    // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
    //    //    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
    //    //    // Add custom user claims here
    //    //    return userIdentity;
    //    //}

    //    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, int> manager, IEnumerable<Claim> customClaims = null)
    //    {
    //        // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
    //        var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

    //        // Add custom user claims here
    //        if (customClaims != null)
    //        {
    //            userIdentity.AddClaims(customClaims.ToArray());
    //        }

    //        return userIdentity;
    //    }
    //}

    public class ApplicationUser : IdentityUser<string, UserLogin, UserRole, UserClaim>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid().ToString();
        }
        public DateTime DateCreated { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, string> manager, IEnumerable<Claim> customClaims = null)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            if (customClaims != null)
            {
                userIdentity.AddClaims(customClaims.ToArray());
            }

            return userIdentity;
        }
    }
}
