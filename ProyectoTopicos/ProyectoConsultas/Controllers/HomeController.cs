using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.WCF;

namespace ProyectoConsultas.Controllers
{
    public class HomeController : Controller
    {
        private Service1 cliente = new Service1();
        public ActionResult Index()
        {

            return View(cliente.Todos()); 
        }
    }
}