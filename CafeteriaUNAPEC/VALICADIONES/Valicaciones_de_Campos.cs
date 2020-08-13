using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaUNAPEC.VALICADIONES
{
    public static class Valicaciones_de_Campos
    {
        //public static ModelValidation noEstaVacio(this string value, string nameField)
        //{
        //    return (new ModelValidation{ boolean = (value.Length > 0), message = nameField+" no debe estar vacío" });
        //}

        public static ModelValidation mayorQueCero(this int value, string nameField)
        {
            return (new ModelValidation { boolean = (value > 0), message = nameField+" no puede ser menor que cero" });
        }

        public static ModelValidation fechaHoy(this DateTime date, string nameField)
        {
            return (new ModelValidation { boolean = (date.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy")), message = nameField+" debe ser la fecha actual" });
        }

        public static ModelValidation fechaMaxima(this DateTime date, DateTime dateParameter, string nameField)
        {
            DateTime fixedDate = new DateTime(date.Year, date.Month, date.Day);
            DateTime fixedDateParameter = new DateTime(dateParameter.Year, dateParameter.Month, dateParameter.Day);
            return (new ModelValidation { boolean = (fixedDate < fixedDateParameter), message = nameField+" no debe ser mayor o igual a "+fixedDateParameter.ToString("dd/MM/yyyy") });
        }

        public static ModelValidation fechaMinima(this DateTime date, DateTime dateParameter, string nameField)
        {
            DateTime fixedDate = new DateTime(date.Year, date.Month, date.Day);
            DateTime fixedDateParameter = new DateTime(dateParameter.Year, dateParameter.Month, dateParameter.Day);
            return (new ModelValidation { boolean = (fixedDate > fixedDateParameter), message = nameField+" no debe ser menor o igual a " + fixedDateParameter.ToString("dd/MM/yyyy") });
        }

        public static ModelValidation numeroMinimo(this int num, int numParameter, string nameField)
        {
            return (new ModelValidation { boolean = (num > numParameter), message = nameField+" seleccionado no debe ser menor o igual que "+numParameter });
        }

        public static ModelValidation numeroMaximo(this int num, int numParameter, string nameField)
        {
            return (new ModelValidation { boolean = (num < numParameter), message = nameField+" seleccionado no debe ser mayor o igual que " + numParameter });
        }

        public static ModelValidation indiceDiferente(this int num, int numParameter, string nameField)
        {
            return (new ModelValidation { boolean = (num != numParameter), message = nameField + " debe tener un indice diferente de " + numParameter+" para que sea valido" });
        }
        public static ModelValidation longitudMaxima(this string value, int numParameter, string nameField)
        {
            return (new ModelValidation { boolean = (numParameter > value.Length), message = nameField + " debe tener una longitud menor que"  + numParameter+" caracteres" });
        }
        public static ModelValidation longitudMinima(this string value, int numParameter, string nameField)
        {
            return (new ModelValidation { boolean = (numParameter < value.Length), message = nameField + " debe tener una longitud mayor que " + numParameter + " caracteres" });
        }
        public static ModelValidation verificarCedula(this string cedula, bool hasSymbols)
        {
            var cedulaParts = new string[3];
            var municipio = string.Empty;
            var digitoVerificador = string.Empty;

            if (hasSymbols)
            {
                if (cedula.Length < 13)
                {
                    return (new ModelValidation {boolean = false, message = "La Cedula no es valida, debe tener 11 digitos sin guiones"});
                }
                else
                {
                    cedulaParts = cedula.Split(new char[] { '-' });
                    municipio = cedulaParts[0].Replace(" ", string.Empty) + cedulaParts[1].Replace(" ", string.Empty);
                    digitoVerificador = cedulaParts[2].Replace(" ", string.Empty);

                    try
                    {
                        Convert.ToInt32(digitoVerificador);
                    }
                    catch (FormatException)
                    {
                        return (new ModelValidation { boolean = false, message = "La Cedula no es valida, debe tener 11 digitos sin guiones" });
                    }
                }
            }
            else
            {
                if (cedula.Length < 11)
                {
                    return (new ModelValidation { boolean = false, message = "La Cedula no es valida, debe tener 11 digitos sin guiones" });
                }
                else
                {
                    cedulaParts[0] = cedula.Substring(0, 3);
                    cedulaParts[1] = cedula.Substring(3, 7);
                    cedulaParts[2] = cedula.Substring(10, 1);

                    municipio = cedulaParts[0] + cedulaParts[1];
                    digitoVerificador = cedulaParts[2];

                    try
                    {
                        Convert.ToInt32(digitoVerificador);
                    }
                    catch (Exception)
                    {
                        return (new ModelValidation {boolean = false, message = "La Cedula no es valida, debe tener 11 digitos sin guiones" });
                    }
                }
            }

            var suma = 0;

            for (int i = 0; i < municipio.Length; i++)
            {
                var mod = "";

                if ((i % 2) == 0)
                    mod = "1";
                else
                    mod = "2";

                var val = string.Empty;

                try
                {
                    var a = municipio.Substring(i, 1);
                    Convert.ToInt32(a);
                    val = a;
                }
                catch (Exception)
                {
                    return (new ModelValidation { boolean = false, message = "La Cedula no es valida, debe tener 11 digitos sin guiones" });
                }

                var res = Convert.ToInt32(Convert.ToInt32(val) * Convert.ToInt32(mod));

                if (res > 9)
                {
                    var res1 = res.ToString();
                    var uno = res1.Substring(0, 1);
                    var dos = res1.Substring(1, 1);
                    res = Convert.ToInt32(uno) + Convert.ToInt32(dos);
                }

                suma += res;
            }

            var elNumero = (10 - (suma % 10) % 10);

            if (elNumero == Convert.ToInt32(digitoVerificador) && cedulaParts[0] != "000")
            {
                return (new ModelValidation { boolean = true, message = "" });
            }
            else
            {
                return (new ModelValidation { boolean = false, message = "La Cedula no es valida, debe tener 11 digitos sin guiones" });
            }
        }

    }

    public class ModelValidation
    {
        public bool boolean { get; set; }
        public string message { get; set; }
    }
}
