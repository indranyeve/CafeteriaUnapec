using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaUNAPEC.VALICADIONES;

namespace CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades
{
    class ProveedoresValidacion : IValidadorEntidades
    {
        string Descripcion;
        string RNC;

        //Mensaje de Validacion
        public string msg;
        public bool boolean;

       public ProveedoresValidacion(string Descripcion, string RNC)
        {
            this.Descripcion = Descripcion;
            this.RNC = RNC;
        }

        public void validar()
        {
            boolean = true;
            if (Descripcion.longitudMinima(3, "Descripcion").boolean == false)
            {
                msg = msg + Descripcion.longitudMinima(3, "Descripcion").message + "\n";
                boolean = false;
            }

           
            //if (RNC.esUnRNCValido(true).boolean == false)
            //{
            //    msg = msg + RNC.verificarCedula(true).message + "\n";
            //    boolean = false;
            //}
        }
    }
}
