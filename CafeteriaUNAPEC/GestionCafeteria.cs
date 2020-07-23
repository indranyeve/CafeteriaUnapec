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
    public partial class GestionCafeteria : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        public GestionCafeteria()
        {
            InitializeComponent();
            ActualizarTabla();
        }

       

        public void LimpiarCampos()
        {
            txtID.Text = "";
            txtDescripcion.Text = "";
            txtCampus.Text = "";
            txtEncargado.Text = "";
        }

        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbSring = "Select * from Cafeteria where Estado = 1";
            SqlCommand Consulta = new SqlCommand(dbSring, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while (Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["CafeteriaID"].ToString(), Lector["Descripcion"].ToString(), Lector["CampusID"].ToString(), Lector["Encargado"].ToString());
                }
                dbCafeteria.Close();
            }
        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                var Descripcion = txtDescripcion.Text;
                var Campus = Convert.ToInt32(txtCampus.Text);
                var Estado = "1";
                var Encargado = txtEncargado.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Cafeteria values('" + Descripcion + "', '" + Campus + "','" + Estado + "','" + Encargado + "')";
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
                var ID = txtID.Text;
                var Descripcion = txtDescripcion.Text;
                var Campus = Convert.ToInt32(txtCampus.Text);
                var Encargado = txtEncargado.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Cafeteria set Descripcion = '" + Descripcion + "', CampusID ='" + Campus + "', Encargado ='" + Encargado + "'Where CafeteriaID =" + ID;
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
       
      

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("No haz seleccionado una fila para eliminar");
            }
            else
            {
                var ID = txtID.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Cafeteria set Estado = 0 Where CafeteriaID =" + ID;
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

        private void GestionCafeteria_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCampus.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEncargado.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }


        private void LimpiarRegistro(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
