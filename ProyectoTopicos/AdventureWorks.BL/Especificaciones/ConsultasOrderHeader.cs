using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.EF.GR.Repositorios;

namespace AdventureWorks.BL.Especificaciones
{
    public class ConsultasOrderHeader
    {
        public Boolean ConsultarPorID(int ID)
        {
            RepOrderHeader Consulta = new RepOrderHeader();
            bool bandera = false;
            var listaOrderHeader = Consulta.ConsultaPorClienteID(ID).ToList();
            int i = listaOrderHeader.Count();
            if (i!=0)
            {
                bandera = true;
            }

            return bandera;
        }
    }
}
