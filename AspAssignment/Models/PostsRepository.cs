using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class PostsRepository:IPostsRepository
    {
        private readonly AppDbContext _appDbContext;
        public PostsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Posts> GetAllPosts
        {
            get
            {
                return _appDbContext.Post.Include(u => u.User);
            }
        }

        public Posts GetPostById(int Post_Id)
        {
            return _appDbContext.Post.FirstOrDefault(p => p.Post_Id == Post_Id);
        }
    }
}
