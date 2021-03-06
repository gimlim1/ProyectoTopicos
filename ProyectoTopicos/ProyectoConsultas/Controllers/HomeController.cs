﻿using System;
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
        
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            String txtfield = fc["Consulta"];
            String Condicion = fc["Condicion"];
            
            if(Condicion.Equals("Customer")){
                int valor = Int32.Parse(txtfield.ToString());
                return View(cliente.ConsultarPorID(valor));
            }
            if (Condicion.Equals("Total")){
                double valor = Double.Parse(txtfield.ToString());
                return View(cliente.ConsultaPorTotal(valor));
            }
            if (Condicion.Equals("Ver Todos")){
                return View(cliente.Todos());
            }
            if (Condicion.Equals("Fecha"))
            {
                String fecha1 = fc["fecha1"];
                String fecha2 = fc["fecha2"];
                DateTime Fecha1 = DateTime.Parse(fecha1);
                DateTime Fecha2 = DateTime.Parse(fecha2);
                return View(cliente.ConsultaPorOrderDate(Fecha1,Fecha2));
            }

            return View(cliente.Todos());

        }
    }

}