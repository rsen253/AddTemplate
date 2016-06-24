﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;

namespace AddTemplate.Controllers
{
    public class BaseController : Controller
    {
        public ApplicationUserManager userManager
        {
            get { return HttpContext.GetOwinContext().Get<ApplicationUserManager>(); }
        }

        public ApplicationSignInManager signInManager
        {
            get { return HttpContext.GetOwinContext().Get<ApplicationSignInManager>(); }
        }
    }
}