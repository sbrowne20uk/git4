﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiserverSite3.Controllers
{
    [AllowAnonymous]
    public class StaticController : Controller
    {
        // GET: Static
        public ActionResult Index()
        {
            return View();
        }
    }
}