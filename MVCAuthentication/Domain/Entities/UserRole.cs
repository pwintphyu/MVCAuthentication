using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRole : IdentityUserRole<string>
    {
        public int Id { get; set; }

        public string Name { set; get; }

        //public override int UserId { get; set; }

        //public override int RoleId { get; set; }
    }
}
