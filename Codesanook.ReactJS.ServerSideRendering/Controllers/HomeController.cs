﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codesanook.ReactJS.ServerSideRendering.Controllers
{
    public class HomeController : Controller
    {
        // GET: React
        public ActionResult Index()
        {
            return View();
        }
    }
}