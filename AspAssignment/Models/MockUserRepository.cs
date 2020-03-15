using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class MockUserRepository:IUserRepository
    {
        public IEnumerable<User> GetAllUsers =>
            new List<User>
            {
                new User{userID=1,UserName="Priyanka@06"},
                new User{userID=2,UserName="Sweta@26"},
                new User{userID=3,UserName="Shush@16"}
            };
    }
}
