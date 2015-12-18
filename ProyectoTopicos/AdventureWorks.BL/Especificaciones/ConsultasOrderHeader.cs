using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.EF.GR.Repositorios;
using AdventureWorks.Modelo;

namespace AdventureWorks.BL.Especificaciones
{
    public class ConsultasOrderHeader
    {
        public List<SalesOrderHeader> ConsultarPorID(int ID)
        {
            RepOrderHeader Consulta = new RepOrderHeader();
            List<SalesOrderHeader> listaOrderHeader = Consulta.ConsultaPorClienteID(ID).ToList();
            return listaOrderHeader;
        }
    }
}
