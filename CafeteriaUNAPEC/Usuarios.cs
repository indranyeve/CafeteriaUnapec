using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUNAPEC
{
    public partial class Usuarios : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;

        public Usuarios()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtLimiteCredito.Text = "";
        }

        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from Usuarios where estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while (Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["idUsuario"].ToString(), Lector["Nombre"].ToString(), Lector["Cedula"].ToString(), 
                        Lector["LimiteCredito"].ToString(), Lector["TipoDeUsuarioID"].ToString(), Lector["FechaRegistro"].ToString());
                }

                dbCafeteria.Close();
            }
        }

        

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var LimiteCredito = txtLimiteCredito.Text;
                //var TiposDeUsuarios;
                var FechaRegistro = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                var Estado = "1";

                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Usuarios values('" + Nombre + "', '" + Cedula + "' , '" + LimiteCredito + "', '" 
                        + "1" + FechaRegistro + "', '" + Estado + "')";

                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();

                }
                catch (Exception)
                {
                    MessageBox.Show("insert into Usuarios (Nombre, Cedula, LimiteCredito, TpoDeUsuarioID, FechaRegistro, Estado) values ('" + Nombre + "', '" + Cedula + "' , '" + LimiteCredito + "', '"
                        + "1" + "', '" + FechaRegistro + "', '" + Estado + "')");
//                    MessageBox.Show("Ha ocurrido un error al insertar un registro, por favor comunicarse con el departamento de soporte tecnico");
                    throw;
                }
            }
            else
            {
                var id = txtID.Text;
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var LimiteCredito = txtLimiteCredito.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Usuarios set Nombre = '" + Nombre+ "', Cedula  ='" + Cedula+ "', LimiteCredito = '" + LimiteCredito +"' where idUsuario =" + id;
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar un registro, comunicarse con el soporte tecnico");
                    throw;
                }
            }
        }

        
        

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCedula.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLimiteCredito.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //Limpiar Campos
        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Eliminar
        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("No has seleccionado una fila para eliminar");
            }
            else
            {
                var id = txtID.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Usuarios set Estado = 0 where idUsuario =" + id;
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar un registro, por favor comunicarse con el departamento de soporte técnico");
                    throw;
                }
            }
        }
    }
}
