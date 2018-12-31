using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy_VueJS_Forms.Models.ViewModels;

namespace Udemy_VueJS_Forms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new MainAppViewModel1();

            ViewBag.ViewModel = viewModel;


            return View();
        }

      
    }
}