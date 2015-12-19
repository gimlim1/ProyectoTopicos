using AdventureWorks.BL.Especificaciones;
using AdventureWorks.Modelo;
using System.Collections.Generic;
using System;

namespace AdventureWorks.OrderDetail.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IAdventureWorksOrderDetail
    {
       public List<SalesOrderDetail> ConsultarPorProductoID(int ID)
        {
            ConsultasOrderDetail Consultar = new ConsultasOrderDetail();
            return Consultar.ConsultarPorProductoID(ID);
        }


        public List<SalesOrderDetail> Todos() {
            ConsultarTodosItemsOrderDetail Consultar = new ConsultarTodosItemsOrderDetail();
            return Consultar.ConsultarTodos();
        }

        public List<SalesOrderDetail> ConsultaPorCantidad(int Cantidad) {
            ConsultasOrderDetail Consultar = new ConsultasOrderDetail();
            return Consultar.ConsultarPorCantidad(Cantidad);
        }


        public List<SalesOrderDetail> ConsultaPorTotal(double Total) {
            ConsultasOrderDetail Consultar = new ConsultasOrderDetail();
            return Consultar.ConsultarTotal(Total);

        }


    }
}
