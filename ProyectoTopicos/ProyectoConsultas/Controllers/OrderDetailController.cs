using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.OrderDetail.WCF;

namespace ProyectoConsultas.Controllers
{
    public class OrderDetailController : Controller
    {

        private Service1 cliente = new Service1();
        // GET: OrderDetail
        public ActionResult Index1()
        {
            return View(cliente.Todos());
        }
    }
}