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
    public partial class GestionMarcas : Form
    {
        private SqlConnection dbCafeteria = new SqlConnection("Data Source=DESKTOP-3AO6C47;Initial Catalog=CafeteriaUNAPEC;Integrated Security=True");

        public GestionMarcas()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            txtDescripcion.Text = "";
        }

        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from Marcas Where Estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while (Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["idMarca"].ToString(), Lector["Descripcion"].ToString(), Lector["Estado"].ToString());
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
                var Estado = "1";

                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Marcas values ('" + Descripcion +"', '" + Estado + "')";
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar un registro, por favor comunicarse con el departamento de soporte tecnico");
                    throw;
                }
            }
            else
            {
                var id = txtID.Text;
                var Descripcion = txtDescripcion.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Marcas set Descripcion = '" + Descripcion + "' Where idMarca =" + id;
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

        //Limpiar Campos
        private void LimpiarRegistros(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                    string dbString = "update Marcas set Estado = 0 where idMarca =" + id;
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
