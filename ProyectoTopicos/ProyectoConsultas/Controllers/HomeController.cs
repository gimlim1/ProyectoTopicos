using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoConsultas.ServiceReference1;

namespace ProyectoConsultas.Controllers
{
    public class HomeController : Controller
    {
        private Service1Client cliente = new Service1Client();
        public ActionResult Index()
        {
            
            return View(cliente.ConsultarPorID(30072));
        }
    }
}