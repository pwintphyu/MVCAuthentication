using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUser : IEntity
    {
        string UserName { get; }
        string Email { get; }
        string DisplayName { get; }
    }
}
