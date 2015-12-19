using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<SalesOrderHeader> ConsultarPorFechas(DateTime Fecha1, DateTime Fecha2)
        {
            RepOrderHeader Consulta = new RepOrderHeader();
            List<SalesOrderHeader> listaOrderHeader = Consulta.ConsultaPorOrderDate(Fecha1, Fecha2).ToList();
            return listaOrderHeader;
        }
        public List<SalesOrderHeader> ConsultarPorTotal(double Total)
        {
            RepOrderHeader Consulta = new RepOrderHeader();
            List<SalesOrderHeader> listaOrderHeader = Consulta.ConsultaPorTotal(Total).ToList();
            return listaOrderHeader;
        }
    }
}
