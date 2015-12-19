using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Modelo;
using AdventureWorks.EF.GR.Interfaces;


namespace AdventureWorks.EF.GR.Repositorios
{
    public class RepOrderDetail : GenericRepository <AdventureWorksEntities, SalesOrderDetail>,
        IOrderDetail
    {

       public IQueryable<SalesOrderDetail> ConsultaPorProductoID(int ProductoID) {
            var query = FindBy(x => (int)x.ProductID == ProductoID);
            return query;
        }

       public  IQueryable<SalesOrderDetail> ConsultaPorCantidad(int Cantidad)
        {
            var query = FindBy(x => (int)x.OrderQty == Cantidad);
            return query;
        }
        public  IQueryable<SalesOrderDetail> ConsultaPorTotal(double Total)
        {
            var query = FindBy(x => (Double)x.LineTotal > Total);
            return query;

        }
        public  IQueryable<SalesOrderDetail> ConsultaTodos()
        {
            var query = GetAll();
            return query;
        }
    }
}
