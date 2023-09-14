using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId = 1, UserName="Sam",UserPwd="Sam@123", UserEmail="sam@gmail.com"},
            new User(){UserId = 2, UserName="Amit",UserPwd="Amit@123", UserEmail="amit@gmail.com"},
            new User(){UserId = 3, UserName="Kumar",UserPwd="Kumar@123", UserEmail="kumar@gmail.com"},
            new User(){UserId = 4, UserName="Anita",UserPwd="Anita@123", UserEmail="anita@gmail.com"},
            new User(){UserId = 5, UserName="Vidisha",UserPwd="Vidisha@123", UserEmail="vidisha@gmail.com"}
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
