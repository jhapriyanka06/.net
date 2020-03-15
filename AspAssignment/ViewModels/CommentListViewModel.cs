using AspAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.ViewModels
{
    public class CommentListViewModel
    {
        public IEnumerable<Comment> comments { get; set; }
    }
}
