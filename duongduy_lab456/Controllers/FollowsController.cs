using duongduy_lab456.Models;
using duongduy_lab456.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace duongduy_lab456.Controllers
{
    public class FollowsController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        public FollowsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Follows
        public ActionResult Index()
        {
            return View();
        }


        [Authorize]
        public ActionResult FollowLecturer()
        {
            var userId = User.Identity.GetUserId();

            var follows = _dbContext.Followings
                .Where(a => a.FollowerId == userId)
                .Select(a => a.Followee)
                .ToList();

            var viewModel = new CoursesViewModel
            {
                Follows = follows,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
        }
    }
}