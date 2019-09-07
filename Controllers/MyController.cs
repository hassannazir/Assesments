using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netAssesment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netAssesment.Controllers
{
    public class MyController : Controller
    {
        private MyDBContext  ORM=null;
        public MyController(MyDBContext _ORM)
        {
            ORM = _ORM;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCategory(Category c)
        {
            ORM.Category.Add(c);
            ORM.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult AddNewPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewPost(Post p)
        {
            ORM.Post.Add(p);
            ORM.SaveChanges();
            return View();
        }
    }
}