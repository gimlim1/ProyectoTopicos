using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.EF.GR.Repositorios;
using AdventureWorks.Modelo;

namespace AdventureWorks.BL.Especificaciones
{
    public class ConsultarTodosItemsOrderDetail
    {
        public List<SalesOrderDetail> ConsultarTodos()
        {
            RepOrderDetail Consulta = new RepOrderDetail();
            List<SalesOrderDetail> lista = Consulta.ConsultaTodos().ToList();
            return lista;
        }
    }
}
