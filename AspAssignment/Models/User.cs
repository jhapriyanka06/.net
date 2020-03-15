using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }
        public string UserName { get; set; }
        public List<Posts> post { get; set; }
    }
}
