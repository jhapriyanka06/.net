using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspAssignment.Models
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllComments(int id);
    }
}
