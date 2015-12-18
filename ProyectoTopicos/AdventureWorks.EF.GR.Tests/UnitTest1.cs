using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks.EF.GR.Repositorios;
using AdventureWorks.Modelo;

using System.Linq;

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

            // invoque al método que consulta en la tabla de stores
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

            // invoque al método que consulta en la tabla de stores
            AdventureWorks.WCF.Service1 servicio = new WCF.Service1();
            var list = servicio.ConsultarPorID(ID).ToList(); 
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

            // invoque al método que consulta en la tabla de stores
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

            // invoque al método que consulta en la tabla de stores
            var repos = new RepOrderHeader();
            var listaOrderHeader = repos.ConsultaPorTotal(Total);
            cantidadReal = listaOrderHeader.Count();

            Assert.IsTrue(cantidadReal == cantidadEsperada);
        }
    }
}
