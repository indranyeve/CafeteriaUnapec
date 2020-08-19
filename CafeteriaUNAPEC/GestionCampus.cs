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
    public partial class GestionCampus : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;
        string IdCafeteria, IdCampus;
        public GestionCampus()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos() 
        {
            IdCafeteria = null;
            txtDescription.Text = "";
        }

        public void ActualizarTabla() 
        {
            // dataGridView1.Rows.Clear();
            string dbString = "Select * from Campus where estado = 1";

            //SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            //dbCafeteria.Open();
            //using (SqlDataReader Lector = Consulta.ExecuteReader()) 
            //{
            //    while (Lector.Read()) 
            //    {
            //        dataGridView1.Rows.Add(Lector["CampusID"].ToString(),Lector["Descripcion"].ToString());
            //    }
            //}
            //dbCafeteria.Close();

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

        //Evento Guardar
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (IdCafeteria == null) 
            {
                var Descripcion = txtDescription.Text;
                var Estado = "1";

                CampusValidacion validador = new CampusValidacion(Descripcion);
                validador.validar();
                bool isValidModel = validador.boolean; 

                if (isValidModel == true)
                {
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
                    //Something To Do Here
                    MessageBox.Show(validador.msg);
                }
            }
            else
            {
                var ID = IdCafeteria;
                var Descripcion = txtDescription.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Campus set Descripcion = '" + Descripcion + "' where CampusID =" + ID;
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

        

        //Eliminar
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

        private void GestionCampus_Load(object sender, EventArgs e)
        {

        }

        //Evento Limpiar
        private void LimpiarRegistros(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdCafeteria = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
