using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Modelo;

namespace AdventureWorks.EF.GR.Interfaces
{
    public interface IOrderHeader
    {
        IQueryable<SalesOrderHeader> ConsultaPorClienteID(int CustomerID);
        IQueryable<SalesOrderHeader> ConsultaPorOrderDate(DateTime Fecha1, DateTime Fecha2);
        IQueryable<SalesOrderHeader> ConsultaPorTotal(double Total);
        IQueryable<SalesOrderHeader> ConsultaTodos();
    }
}
