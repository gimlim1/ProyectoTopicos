using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.EF.GR.Repositorios;
using AdventureWorks.Modelo;


namespace AdventureWorks.BL.Especificaciones
{
   public  class ConsultasOrderDetail
    {
        public List<SalesOrderDetail> ConsultarPorProductoID(int ID)
        {
            RepOrderDetail Consulta = new RepOrderDetail();
            List<SalesOrderDetail> lista = Consulta.ConsultaPorProductoID(ID).ToList();
            return lista;
        }
        public List<SalesOrderDetail> ConsultarPorCantidad(int Cantidad)
        {
            RepOrderDetail Consulta = new RepOrderDetail();
            List<SalesOrderDetail> lista = Consulta.ConsultaPorCantidad(Cantidad).ToList();
            return lista;
        }
        public List<SalesOrderDetail> ConsultarTotal(double total)
        {
            RepOrderDetail Consulta = new RepOrderDetail();
            List<SalesOrderDetail> lista = Consulta.ConsultaPorTotal(total).ToList();
            return lista;
        }
    }
}
