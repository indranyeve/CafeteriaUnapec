using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaUNAPEC.VALICADIONES;

namespace CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades
{
    class EmpleadoValidacion : IValidadorEntidades
    {
        string Nombre;
        string Cedula;
        int PorcientoComision;
        string TandaLabor;

        //Mensaje de Validacion
        public string msg;
        public bool boolean;

        public EmpleadoValidacion(string Nombre, string Cedula, int PorcientoComision, string TandaLabor)
        {
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.PorcientoComision = PorcientoComision;
            this.TandaLabor = TandaLabor;
        }

        public void validar()
        {
            boolean = true;
            if (Nombre.longitudMinima(3, "Nombre").boolean == false)
            {
                msg = msg + Nombre.longitudMinima(3, "Nombre").message + "\n";
                boolean = false;
            }
            if (Cedula.verificarCedula(true).boolean == false)
            {
                msg = msg + Cedula.verificarCedula(true).message + "\n";
                boolean = false;
            }
            if (PorcientoComision.mayorQueCero("Porciento Comision").boolean == false)
            {
                msg = msg + PorcientoComision.mayorQueCero("PorcientoComision").message + "\n";
                boolean = false;
            }
            if (PorcientoComision.numeroMaximo(31, "Porciento Comision").boolean == false)
            {
                msg = msg + PorcientoComision.numeroMaximo(31, "Porciento Comision").message + "\n";
                boolean = false;
            }

            //if (TandaLabor.longitudMinima(3, "TandaLabor").boolean == false)
            //{
            //    msg = msg + TandaLabor.longitudMinima(3, "TandaLabor").message + "\n";
            //    boolean = false;
            //}

            //if (TandaLabor.indiceDiferente(1, "TandaLabor").boolean == false)
            //{
            //    msg = msg + TandaLabor.indiceDiferente(1, "TandaLabor").message + "\n";
            //    boolean = false;
            //}
        }
    }
}
