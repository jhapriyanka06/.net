using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class Posts
    {
        [Key]
        public int Post_Id { get; set; }
        public string UserName { get; set; }
        public string Post { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public User User { get; set; }
    }
}
