﻿using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;
using System.IO;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {
            return this.View();
        }
    }
}