using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CafeteriaUNAPEC.VALICADIONES;

namespace CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades
{
    public class ArticuloValidacion : IValidadorEntidades
    {

        string Descripcion;
        int Costo;
        int Proveedor;
        int Marca;
        int Existencia;

        //Mensaje de Validacion
        public string msg;
        public bool boolean;

        public ArticuloValidacion(string Descripcion, int Costo, int Proveedor, int Marca, int Existencia)
        {
            this.Descripcion = Descripcion;
            this.Costo = Costo;
            this.Proveedor = Proveedor;
            this.Marca = Marca;
            this.Existencia = Existencia;
        }
        public void validar()
        {
            boolean = true;
            if (Descripcion.longitudMinima(3, "Descripcion").boolean == false)
            {
                msg = msg + Descripcion.longitudMinima(3, "Descripcion").message + "\n";
                boolean = false;
            }
            if (Costo.mayorQueCero("Costo").boolean == false)
            {
                msg = msg + Costo.mayorQueCero("Costo").message + "\n";
                boolean = false;
            }
            if (Proveedor.indiceDiferente(1, "Proveedor").boolean == false)
            {
                msg = msg + Proveedor.indiceDiferente(1, "Proveedor").message + "\n";
                boolean = false;
            }
            if (Marca.indiceDiferente(1, "Marca").boolean == false)
            {
                msg = msg + Marca.indiceDiferente(1, "Marca").message + "\n";
                boolean = false;
            }
            if (Existencia.mayorQueCero("Existencia").boolean == false)
            {
                msg = msg + Existencia.mayorQueCero("Existencia").message + "\n";
                boolean = false;
            }
        }
    }
}

