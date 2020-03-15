using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class MockPostsRepository:IPostsRepository
    {
        private readonly IUserRepository _userRepository = new MockUserRepository();
        public IEnumerable<Posts> GetAllPosts =>
            new List<Posts>
            {
                new Posts {Post_Id=1,Post="This Is My First Post..Thankyou", Likes=3, Comments=7},
                new Posts {Post_Id=2,Post="This Is Shusnavi's first Post..Thankyou", Likes=9, Comments=4},
                new Posts {Post_Id=3,Post="Thankyou For Watching My First Post", Likes=4, Comments=5},
                new Posts {Post_Id=4,Post="KeepWatching..There,s Something Interesting To Come..", Likes=24, Comments=5}
            };
        public Posts GetPostById(int Post_Id)
        {
            return GetAllPosts.FirstOrDefault(p => p.Post_Id == Post_Id);
        }
    }
}
