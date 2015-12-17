using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
