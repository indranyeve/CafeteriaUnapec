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
    public partial class GestionProveedores : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;

        public GestionProveedores()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            txtID.Text = "";
            txtNombreComercial.Text = "";
            txtRNC.Text = "";
        }

        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from Proveedor where Estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while (Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["ProveedorID"].ToString(), Lector["NombreComercial"].ToString(), Lector["RNC"].ToString(), 
                        Lector["FechaIngreso"].ToString());
                }
                dbCafeteria.Close();
            }
        }

        
        private void GestionProveedores_Load(object sender, EventArgs e)
        {

        }


        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                var NombreComercial = txtNombreComercial.Text;
                var RNC = txtRNC.Text;
                string fechaIngreso = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                var Estado = "1";

                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Proveedor values ('" + NombreComercial + "','" + RNC + "','" + fechaIngreso + "','" + Estado + "')";
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
                var NombreComercial = txtNombreComercial.Text;
                var RNC = txtRNC.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Proveedor set NombreComercial = '" + NombreComercial+ "', RNC = '" + RNC + "' where ProveedorID =" + ID;
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
        private void LimpiarRegistro(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombreComercial.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRNC.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                var ID = txtID.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Proveedor set Estado = 0 Where ProveedorID =" + ID;
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
