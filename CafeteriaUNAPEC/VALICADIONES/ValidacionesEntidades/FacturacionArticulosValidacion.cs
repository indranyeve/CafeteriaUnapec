using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaUNAPEC.VALICADIONES;

namespace CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades
{
    class FacturacionArticulosValidacion : IValidadorEntidades
    {
        int EmpleadoID;
        int ArticuloID;
        int Monto;
        int UnidadVendida;
        string Comentario;

        //Mensaje de Validacion
        public string msg;
        public bool boolean;

        public FacturacionArticulosValidacion(int EmpleadoID, int ArticuloID, int Monto, int UnidadVendida, string Comentario)
        {
            this.EmpleadoID = EmpleadoID;
            this.ArticuloID = ArticuloID;
            this.Monto = Monto;
            this.UnidadVendida = UnidadVendida;
            this.Comentario = Comentario;
        }

        public void validar()
        {
            boolean = true;
            if (EmpleadoID.indiceDiferente(1, "Empleado").boolean == false)
            {
                msg = msg + EmpleadoID.indiceDiferente(1, "Empleado").message + "\n";
                boolean = false;
            }
            if (ArticuloID.indiceDiferente(1, "Articulo").boolean == false)
            {
                msg = msg + ArticuloID.indiceDiferente(1, "Articulo").message + "\n";
                boolean = false;
            }
            if (Monto.mayorQueCero("Monto").boolean == false)
            {
                msg = msg + Monto.mayorQueCero("Monto").message + "\n";
                boolean = false;
            }
            if (UnidadVendida.mayorQueCero("Unidad Vendida").boolean == false)
            {
                msg = msg + Monto.mayorQueCero("Unidad Vendida").message + "\n";
                boolean = false;
            }
           
            if (Comentario.longitudMinima(3, "Comentario").boolean == false)
            {
                msg = msg + Comentario.longitudMinima(3, "Comentario").message + "\n";
                boolean = false;
            }


        }
    }
}
