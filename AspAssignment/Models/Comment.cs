using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class Comment
    {
        [Key]
        public int Comment_Id { get; set; }
        public int Post_Id { get; set; }
        public string comments { get; set; }
        public Posts Posts { get; set; }
    }
}
