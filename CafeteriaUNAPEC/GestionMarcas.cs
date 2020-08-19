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
    public partial class GestionMarcas : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;
        string IdMarcas;

        public GestionMarcas()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            IdMarcas = null;
            txtDescripcion.Text = "";
        }

        public void ActualizarTabla()
        {
            //dataGridView1.Rows.Clear();
            string dbString = "Select * from Marca Where Estado = 1";
            //SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            //dbCafeteria.Open();
            //using (SqlDataReader Lector = Consulta.ExecuteReader())
            //{
            //    while (Lector.Read())
            //    {
            //        dataGridView1.Rows.Add(Lector["MarcaID"].ToString(), Lector["Descripcion"].ToString());
            //    }
            //    dbCafeteria.Close();
            //}

            try
            {
                dataAdapter = new SqlDataAdapter(dbString, dbCafeteria);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (IdMarcas == null)
            {
                var Descripcion = txtDescripcion.Text;
                var Estado = "1";

                MarcasValidacion validador = new MarcasValidacion(Descripcion);
                validador.validar();
                bool isValidModel = validador.boolean;

                if (isValidModel == true)
                {
                    try
                    {
                        dbCafeteria.Open();
                        string dbString = "insert into Marca values ('" + Descripcion + "', '" + Estado + "')";
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
                var ID = IdMarcas;
                var Descripcion = txtDescripcion.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Marca set Descripcion = '" + Descripcion + "' Where MarcaID =" + ID;
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
        private void LimpiarRegistros(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdMarcas = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        //Eliminar
        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (IdMarcas == null)
            {
                MessageBox.Show("No has seleccionado una fila para eliminar");
            }
            else
            {
                var id = IdMarcas;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Marca set Estado = 0 where MarcaID =" + id;
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

        private void GestionMarcas_Load(object sender, EventArgs e)
        {

        }
    }
}
