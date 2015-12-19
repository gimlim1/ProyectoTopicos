using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Modelo;

namespace AdventureWorks.EF.GR.Interfaces
{
    public interface IOrderDetail
    {

        IQueryable<SalesOrderDetail> ConsultaPorProductoID(int ProductoID);
        IQueryable<SalesOrderDetail> ConsultaPorCantidad(int Cantidad);
        IQueryable<SalesOrderDetail> ConsultaPorTotal(double Total);
        IQueryable<SalesOrderDetail> ConsultaTodos();
    }
}
