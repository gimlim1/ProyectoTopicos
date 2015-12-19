using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks.EF.GR.Repositorios;
using AdventureWorks.Modelo;


using System.Linq;
using System.Collections.Generic;

namespace AdventureWorks.EF.GR.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QueryCustomerID()
        {
       
            int ID = 29847;
            var cantidadEsperada = 1;
            var cantidadReal = 0;


            var repos = new RepOrderHeader();
            var listaOrderHeader = repos.ConsultaPorClienteID(ID).ToList();
            cantidadReal = listaOrderHeader.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }
        [TestMethod]
        public void QueryWCF()
        {

            int ID = 29847;
            var cantidadEsperada = 1;
            var cantidadReal = 0;

           
            AdventureWorks.WCF.Service1 servicio = new WCF.Service1();
            List<SalesOrderHeader> list = servicio.ConsultarPorID(ID).ToList();
            cantidadReal = list.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }

        [TestMethod]
        public void QueryOrderDate()
        {

            DateTime fecha1 = DateTime.Parse("2008 - 06 - 01");
            DateTime fecha2 = DateTime.Parse("2008 - 06 - 01");
            var cantidadEsperada = 31;
            var cantidadReal = 0;


            var repos = new RepOrderHeader();
            var listaOrderHeader = repos.ConsultaPorOrderDate(fecha1, fecha2);
            cantidadReal = listaOrderHeader.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }

        [TestMethod]
        public void QueryOrderTotal()
        {

            Double Total = 50000;
            var cantidadEsperada = 8;
            var cantidadReal = 0;

            var repos = new RepOrderHeader();
            var listaOrderHeader = repos.ConsultaPorTotal(Total);
            cantidadReal = listaOrderHeader.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }
        [TestMethod]
        public void QueryProductID()
        {
            int idProducto = 715;

            var cantidadEsperada = 10;
            var cantidadReal = 0;

            // invoque al método que consulta en la tabla de stores
            var repos = new RepOrderDetail();
            var listaOrder = repos.ConsultaPorProductoID(idProducto);
            cantidadReal = listaOrder.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }
        [TestMethod]
        public void QueryOrderCantidad()
        {

            int Cantidad = 5;
            var cantidadEsperada = 46;
            var cantidadReal = 0;

     
            var repos = new RepOrderDetail();
            var listaOrder = repos.ConsultaPorCantidad(Cantidad);
            cantidadReal = listaOrder.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }

        [TestMethod]
        public void QueryOrderDetailTotal()
        {

            double total = 10000;
            var cantidadEsperada = 9;
            var cantidadReal = 0;

         
            var repos = new RepOrderDetail();
            var listaOrder = repos.ConsultaPorTotal(total);
            cantidadReal = listaOrder.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }
    }

}
