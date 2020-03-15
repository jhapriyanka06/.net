using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspAssignment.Models;
using AspAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspAssignment.Controllers
{
    public class PostsController : Controller
    {
        private IPostsRepository _postsRepository;
        private IUserRepository _userRepository;
        private readonly AppDbContext _auc;
        private ICommentRepository _commentRepository;
        public PostsController(IPostsRepository postsrepository, IUserRepository userrepository,
            ICommentRepository commentrepository,AppDbContext appdbcontext)
        {
            _postsRepository = postsrepository;
            _userRepository = userrepository;
            _commentRepository = commentrepository;
            _auc = appdbcontext;
        }
        [HttpGet]
        public ViewResult List()
        {
            PostsListViewModel postslistviewmodel = new PostsListViewModel();
            postslistviewmodel.posts = _postsRepository.GetAllPosts;
            return View(postslistviewmodel);
        }
        [HttpPost]
        public ViewResult List(Posts pst)
        {
            pst.UserName = "priyanka";
            _auc.Add(pst);
            _auc.SaveChanges();
            PostsListViewModel postslistviewmodel = new PostsListViewModel();
            postslistviewmodel.posts = _postsRepository.GetAllPosts;
            return View(postslistviewmodel);
        }
        public ViewResult Comment(int id)
        {
            CommentListViewModel commentlistviewmodel = new CommentListViewModel();
            commentlistviewmodel.comments = _commentRepository.GetAllComments(id);
            return View(commentlistviewmodel);
        }

    }
}
