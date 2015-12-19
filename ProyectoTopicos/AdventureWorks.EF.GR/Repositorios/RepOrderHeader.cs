using System;
using System.Linq;
using AdventureWorks.Modelo;
using AdventureWorks.EF.GR.Interfaces;

namespace AdventureWorks.EF.GR.Repositorios
{
    public class RepOrderHeader : GenericRepository<AdventureWorksEntities, SalesOrderHeader>,
        IOrderHeader
    {

        public IQueryable<SalesOrderHeader> ConsultaPorClienteID(int CustomerID){
            var query = FindBy(x => (int)x.CustomerID == CustomerID);
            return query;
        }

        public IQueryable<SalesOrderHeader> ConsultaPorOrderDate(DateTime Fecha1,DateTime Fecha2)
        {
            var query = FindBy(x => (DateTime)x.OrderDate >= Fecha1 && x.OrderDate <= Fecha2);
            return query;
        }
        public IQueryable<SalesOrderHeader> ConsultaPorTotal(double Total)
        {
            var query = FindBy(x => (Double)x.TotalDue > Total);
            return query;
        }

        public IQueryable<SalesOrderHeader> ConsultaTodos()
        {
            var query = GetAll();
            return query;
        }


    }
}
