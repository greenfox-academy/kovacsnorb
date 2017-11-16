﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApiProject.Repositories;
using RedditApiProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditApiProject.Controllers
{
    public class PostController : Controller
    {
        PostRepository postRepository;

        public PostController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [HttpGet]
        [Route("posts")]
        public IActionResult GetAllPosts()
        {
            return Json(postRepository.FillList());
        }

        [HttpPost]
        [Route("posts")]
        public IActionResult AddPosts([FromBody] Post postFromBody )
        {
            postRepository.AddPostToList(postFromBody);
            return Json(postRepository.GetLastPost());
        }
    }
}