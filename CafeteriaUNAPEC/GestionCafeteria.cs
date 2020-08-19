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
using CafeteriaUNAPEC.VALICADIONES;
using CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades;

namespace CafeteriaUNAPEC
{
    public partial class GestionCafeteria : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;
        string IdCampus, IdCafeteria;

        public GestionCafeteria()
        {
            InitializeComponent();
            ActualizarTabla();
        }

       

        public void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            cbxCampus.SelectedIndex = 0;
            txtEncargado.Text = "";
            IdCafeteria = null;
        }

        public void ActualizarTabla()
        {
            //dataGridView1.Rows.Clear();
            string dbString = "select Cafeteria.CafeteriaID, Campus.Descripcion as 'Campus', Cafeteria.Descripcion, Cafeteria.Encargado, Cafeteria.Estado from Cafeteria inner join Campus on Cafeteria.CampusID = Campus.CampusID where Cafeteria.Estado = 1;";
       

            try
            {
                dataAdapter = new SqlDataAdapter(dbString, dbCafeteria);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void LlenarComboBoxCampus()
        {
            dbCafeteria.Open();
            string query = "select CampusID, Descripcion from Campus where Estado = 1";
            Command = new SqlCommand(query, dbCafeteria);
            dataAdapter = new SqlDataAdapter(Command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dbCafeteria.Close();

            cbxCampus.ValueMember = "CampusID";
            cbxCampus.DisplayMember = "Descripcion";
            cbxCampus.DataSource = dataTable;
        }
                    
        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (IdCafeteria == null)
            {
                var Descripcion = txtDescripcion.Text;
                var Campus = Convert.ToInt32(IdCampus);
                var Encargado = txtEncargado.Text;
                var Estado = "1";

                CafeteriaValidacion validador = new CafeteriaValidacion(Descripcion, Campus, Encargado);
                validador.validar();
                bool isValidModel = validador.boolean;

                if (isValidModel == true)
                {
                    try
                    {
                        dbCafeteria.Open();
                        string dbString = "insert into Cafeteria values('" + Descripcion + "', '" + Campus + "', '" + Estado + "', '" + Encargado + "')";
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
                    //Something To Do Here
                    MessageBox.Show(validador.msg);
                }
            }
            else
            {
                var ID = IdCafeteria;
                var Descripcion = txtDescripcion.Text;
                var Campus = Convert.ToInt32(IdCampus);
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
            if (IdCafeteria == null)
            {
                MessageBox.Show("No haz seleccionado una fila para eliminar");
            }
            else
            {
                var ID = IdCafeteria;
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
            LlenarComboBoxCampus();
            cbxCampus.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LimpiarRegistro(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void cbxCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCampus = cbxCampus.SelectedValue.ToString();
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdCafeteria = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbxCampus.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEncargado.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
