using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<User> GetAllUsers => _appDbContext.Users;
    }
}
