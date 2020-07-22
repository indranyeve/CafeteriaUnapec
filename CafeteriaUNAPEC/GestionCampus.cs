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
    public partial class GestionCampus : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        public GestionCampus()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos() 
        {
            txtID.Text = "";
            txtDescription.Text = "";
            txtEstado.Text = "";
        }

        public void ActualizarTabla() 
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from Campus where estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader()) 
            {
                while (Lector.Read()) 
                {
                    dataGridView1.Rows.Add(Lector["CampusID"].ToString(),Lector["Descripcion"].ToString(),Lector["Estado"].ToString());
                }
            }
            dbCafeteria.Close();

        }

        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") 
            {
                //var ID = txtID.Text;
                var Descripcion = txtDescription;
                var Estado = "1";

                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Campus values('" + Descripcion + "', '" + Estado + "')";
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
                var Descripcion = txtDescription.Text;
                var Estado = txtEstado.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Campus set Descripcion = '" + Descripcion + "', Estado = '" + Estado + "' where CampusID =" + ID;
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
        private void LimpiarRegistro (object sender, EventArgs e) 
        {
            LimpiarCampos();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                    string dbString = "update Campus set Estado = 0 Where CampusID =" + ID;
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
    }
}
