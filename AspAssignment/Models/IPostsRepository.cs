using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public interface IPostsRepository
    {
        IEnumerable<Posts> GetAllPosts { get; }
        Posts GetPostById(int Post_Id);
    }
}
