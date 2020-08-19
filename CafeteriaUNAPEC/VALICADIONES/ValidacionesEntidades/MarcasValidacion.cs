using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaUNAPEC.VALICADIONES;

namespace CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades
{
    class MarcasValidacion : IValidadorEntidades
    {
        string Descripcion;

        //Mensaje de Validacion
        public string msg;
        public bool boolean;

        public MarcasValidacion(string Descripcion)
        {
            this.Descripcion = Descripcion;
        }

        public void validar()
        {
            boolean = true;
            if (Descripcion.longitudMinima(3, "Descripcion").boolean == false)
            {
                msg = msg + Descripcion.longitudMinima(3, "Descripcion").message + "\n";
                boolean = false;
            }
        }
    }
}
