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
            var cantidadMinimaEsperada = 1;
            var cantidadReal = 0;

            // invoque al método que consulta en la tabla de stores
            var repos = new RepOrderHeader();
            var listaOrderHeader = repos.ConsultaPorClienteID(ID).ToList();
            cantidadReal = listaOrderHeader.Count();

            Assert.IsTrue(cantidadReal >= cantidadMinimaEsperada);
        }
    }
}
