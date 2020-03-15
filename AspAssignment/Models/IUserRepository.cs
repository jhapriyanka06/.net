using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers { get; }
    }
}
