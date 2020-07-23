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
    public partial class GestionUsuarios : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        public GestionUsuarios()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        public void LimpiarCampos()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtLimiteCredito.Text = "";
            txtTipoDeUsuario.Text = "";
        }

        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from Usuario where Estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while (Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["UsuarioID"].ToString(), Lector["Nombre"].ToString(), Lector["Cedula"].ToString(), Lector["TipoDeUsuarioID"].ToString(),
                    Lector["LimiteCredito"].ToString(), Lector["FechaRegistro"].ToString());
                }
                dbCafeteria.Close();
            }
        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (txtID.Text =="")
            {
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var TipoDeUsuario = Convert.ToInt32(txtTipoDeUsuario.Text);
                var LimiteCredito = txtLimiteCredito.Text;
                var FechaRegistro = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                var Estado = "1";

                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Usuario values('"+Nombre+"', '"+Cedula+"','"+ TipoDeUsuario+"', '" +LimiteCredito+"','"+FechaRegistro+"' , '"+Estado+"')";
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar un registro");
                    throw;
                }
            }
            else
            {
                var id = txtID.Text;
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var TipoDeUsuario = Convert.ToInt32(txtTipoDeUsuario.Text);
                var LimiteCredito = txtLimiteCredito.Text;
                

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Usuario set Nombre = '" + Nombre + "', Cedula = '" + Cedula + "', TipoDeUsuarioID ='"+ TipoDeUsuario+ "', LimiteCredito = '"+ LimiteCredito +"' where UsuarioID =" + id;

                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar un registro");
                    throw;
                }
            }
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
                MessageBox.Show("No haz seleccionado una fila para eliminar");
            }
            else
            {
                var id = txtID.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Usuario set Estado = 0 Where UsuarioID =" + id;
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un error al actualizar un registro");
                    throw;
                }
            }
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCedula.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLimiteCredito.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTipoDeUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
