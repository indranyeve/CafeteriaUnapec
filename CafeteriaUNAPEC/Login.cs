using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeteriaUNAPEC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Conexion a base de datos

        //private SqlConnection dbCafeteria = connection.cadenaConexion;

        //evento el boton "ingresar"
        private void bttIngresar_Click(object sender, EventArgs e)
        {
           
        }

        private void bttIngresar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Campos vacios");
                return;
            }
            try
            {
                //Conexion a base de datos
                SqlConnection con = connection.cadenaConexion;
                SqlCommand cmd = new SqlCommand("Select * from Login where Usuario=@usuario and Clave=@clave", con);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@clave", txtClave.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int contador = ds.Tables[0].Rows.Count;

                //Si es igual a uno debe mostrar el menu
                if (contador == 1)
                {
                    MessageBox.Show("Bienvenid@!");
                    this.Hide();
                    Menu form = new Menu();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Error al ingresar!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
