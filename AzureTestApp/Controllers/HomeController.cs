﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "hahaha Apps About Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "hahahaha modified it";

            return View();
        }
    }
}