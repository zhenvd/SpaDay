using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        static private List<User> Users = new List<User>();
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //[Route("/user/add/")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/user")]
        //[Route("/user/add/")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if(newUser.Password == verify)
            {
                //User user = new User(newUser.Username, newUser.Email, newUser.Password);
                ViewBag.users = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.users = newUser;
                ViewBag.error = true;
                return View("Add");
            //return View("Add");
            }
           
        }
    }
}
