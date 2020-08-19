using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaUNAPEC.VALICADIONES;


namespace CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades
{
    class CafeteriaValidacion : IValidadorEntidades
    {
        string Descripcion;
        int Campus;
        string Encargado;

        //Mensaje de Validacion
        public string msg;
        public bool boolean;

        public CafeteriaValidacion(string Descripcion, int Campus, string Encargado)
        {
            this.Descripcion = Descripcion;
            this.Campus = Campus;
            this.Encargado = Encargado;
        }

        public void validar()
        {
            boolean = true;
            if (Descripcion.longitudMinima(3, "Descripcion").boolean == false)
            {
                msg = msg + Descripcion.longitudMinima(3, "Descripcion").message + "\n";
                boolean = false;
            }
            if (Encargado.longitudMinima(3, "Encargado").boolean == false)
            {
                msg = msg + Descripcion.longitudMinima(3, "Encargado").message + "\n";
                boolean = false;
            }
            if (Campus.indiceDiferente(1, "Campus").boolean == false)
            {
                msg = msg + Campus.indiceDiferente(1, "Campus").message + "\n";
                boolean = false;
            }
        }
    }
}
