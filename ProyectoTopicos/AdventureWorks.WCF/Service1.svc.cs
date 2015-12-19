using AdventureWorks.BL.Especificaciones;
using AdventureWorks.Modelo;
using System;
using System.Collections.Generic;

namespace AdventureWorks.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<SalesOrderHeader> ConsultarPorID(int ID)
        {
            ConsultasOrderHeader Consultar = new ConsultasOrderHeader();  
            return Consultar.ConsultarPorID(ID);
        }
        public List<SalesOrderHeader> Todos()
        {
            ConsultarTodosItems Todos = new ConsultarTodosItems();
            return Todos.ConsultarTodos();
        }
        public List<SalesOrderHeader> ConsultaPorOrderDate(DateTime Fecha1, DateTime Fecha2)
        {
            ConsultasOrderHeader Consultar = new ConsultasOrderHeader();
            return Consultar.ConsultarPorFechas(Fecha1, Fecha2);
        }

        public List<SalesOrderHeader> ConsultaPorTotal(double Total) {
            ConsultasOrderHeader Consultar = new ConsultasOrderHeader();
            return Consultar.ConsultarPorTotal(Total);

        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
