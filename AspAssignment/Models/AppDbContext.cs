using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Posts> Post { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Posts
            modelBuilder.Entity<Posts>().HasData(new Posts { Post_Id = 1, UserName = "jha@06", Post = "This Is My First Post...Thankyou", Comments = 6 });
            modelBuilder.Entity<Posts>().HasData(new Posts { Post_Id = 2, UserName = "shus@16", Post = "This Is Shusnavi's First Post...Thankyou", Comments = 8 });
            modelBuilder.Entity<Posts>().HasData(new Posts { Post_Id = 3, UserName = "sweta@26", Post = "Thankyou For Reading My First Post", Comments = 5 });

            //seed user
            modelBuilder.Entity<User>().HasData(new User { userID = 1, UserName = "jha@06" });
            modelBuilder.Entity<User>().HasData(new User { userID = 2, UserName = "shus@16" });
            modelBuilder.Entity<User>().HasData(new User { userID = 3, UserName = "sweta@26" });

            //seed comments
            modelBuilder.Entity<Comment>().HasData(new Comment { Comment_Id = 1, Post_Id = 1, comments = "Reply To Your first Post" });
            modelBuilder.Entity<Comment>().HasData(new Comment { Comment_Id = 2, Post_Id = 2, comments = "Reply To Your second Post" });
            modelBuilder.Entity<Comment>().HasData(new Comment { Comment_Id = 3, Post_Id = 1, comments = "Reply To Your first Post but second time" });
            modelBuilder.Entity<Comment>().HasData(new Comment { Comment_Id = 4, Post_Id = 3, comments = "Reply To Your third Post" });
            modelBuilder.Entity<Comment>().HasData(new Comment { Comment_Id = 5, Post_Id = 3, comments = "Reply To Your third Post but second time" });
            modelBuilder.Entity<Comment>().HasData(new Comment { Comment_Id = 6, Post_Id = 2, comments = "Reply To the Post" });
        }
    }
}
