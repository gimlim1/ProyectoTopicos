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

        [HttpPost]
        public ActionResult Index1(FormCollection fc)
        {
            String txtfield = fc["Consulta"];
            String Condicion = fc["Condicion"];

            if (Condicion.Equals("Product"))
            {
                int valor = Int32.Parse(txtfield.ToString());
                return View(cliente.ConsultarPorProductoID(valor));
            }
            if (Condicion.Equals("Total"))
            {
                double valor = Double.Parse(txtfield.ToString());
                return View(cliente.ConsultaPorTotal(valor));
            }
            if (Condicion.Equals("Ver Todos"))
            {
                return View(cliente.Todos());
            }
            if (Condicion.Equals("Cantidad"))
            {
                int valor = Int32.Parse(txtfield.ToString());
                return View(cliente.ConsultaPorCantidad(valor));
            }

            return View(cliente.Todos());

        }
    }
}