﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BS.MVC.Git.Controllers
{
    public class productController : Controller
    {
        // GET: product
        public ActionResult Index()
        {
            ViewData["Info"] = "Hello";
            return View();
        }


    }
}