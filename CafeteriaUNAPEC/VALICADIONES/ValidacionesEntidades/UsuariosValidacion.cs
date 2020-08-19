using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaUNAPEC.VALICADIONES;

namespace CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades
{
    class UsuariosValidacion : IValidadorEntidades
    {
        string Nombre;
        string Cedula;
        int LimiteCredito;
        int TipoDeUsuario;

        //Mensaje de Validacion
        public string msg;
        public bool boolean;

        public UsuariosValidacion(string Nombre, string Cedula, int LimiteCredito, int TipoDeUsuario)
        {
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.LimiteCredito = LimiteCredito;
            this.TipoDeUsuario = TipoDeUsuario;
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

            if (LimiteCredito.mayorQueCero("Limite de Credito").boolean == false)
            {
                msg = msg + LimiteCredito.mayorQueCero("Limite de Credito").message + "\n";
                boolean = false;
            }
            if (LimiteCredito.numeroMaximo(1000, "Limite de Credito").boolean == false)
            {
                msg = msg + LimiteCredito.numeroMaximo(1000, "Limite de Credito").message + "\n";
                boolean = false;
            }
            if (TipoDeUsuario.indiceDiferente(1, "Tipo de Usuario").boolean == false)
            {
                msg = msg + TipoDeUsuario.indiceDiferente(1, "Tipo de Usuario").message + "\n";
                boolean = false;
            }
        }

    }
}
