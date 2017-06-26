using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetBeeTicket.Models;
using NetBeeTicket.ViewModels;

namespace NetBeeTicket.Controllers
{
    public class CustomerController : Controller
    {
       public ActionResult New()
        {
            return View();
        }

        public ActionResult Index()
        {
          
            return View();
            
        }


    }
}