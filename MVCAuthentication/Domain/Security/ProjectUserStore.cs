using Domain.Context;
using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Security
{
    public class ProjectUserStore : UserStore<ApplicationUser, Role, string, UserLogin, UserRole, UserClaim>
    {
        public ProjectUserStore(ProjectDbContext context)
            : base(context)
        {
        }
    }
}
