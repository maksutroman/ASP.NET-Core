﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Entityes;
using MyBlog.Interfaces;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPostRepository _postRepository;  

        public HomeController(IPostRepository postRepository )
        {
            _postRepository = postRepository;
        }

        [AllowAnonymous]
        public IActionResult Home_Page()
        {
            var posts = _postRepository.GetAllPosts().ToList();
            return View(posts);
           // return View();
        }
        [AllowAnonymous]
        public IActionResult Portfolio()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Services()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Contact()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Blog_post()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
