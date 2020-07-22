
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
    public partial class GestionArticulos: Form

    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        public GestionArticulos()
        {
            InitializeComponent();
            ActualizarTabla();

        }

        public void LimpiarCampos()
        {
            txtID.Text = "";
            txtDescription.Text = "";
            txtMarca.Text = "";
            txtCosto.Text = "";
            txtProveedor.Text = "";
            txtExistencia.Text = "";
        }

        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from Articulo where Estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while (Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["ArticuloID"].ToString(), Lector["Descripcion"].ToString(),
                        Lector["MarcaID"].ToString(), Lector["Costo"].ToString(), Lector["ProveedorID"].ToString(),
                        Lector["Existencia"].ToString());

                }
                dbCafeteria.Close();
            }
        }



        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                var Descripcion = txtDescription.Text;
                var Marca = txtMarca.Text;
                var Costo = txtCosto.Text;
                var Proveedor = txtProveedor.Text;
                var Existencia = txtExistencia.Text;
                var Estado = "1";
                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Articulo values('" + Descripcion + "', '" + Marca + "', '" + Costo + "', '"
                        + Proveedor + "', '" + Existencia + "', '" + Estado + "')";
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
                var Marca = txtMarca.Text;
                var Costo = txtCosto.Text;
                var Proveedor = txtProveedor.Text;
                var Existencia = txtExistencia.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Articulo set Descripcion = '" + Descripcion + "', MarcaID = '" + Marca + "', Costo = '" + Costo + "', ProveedorID = '" + Proveedor +"'Existencia ='" + Existencia + "' where ArticuloID =" + ID;
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
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarca.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCosto.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtProveedor.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtExistencia.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                var ID = txtID.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Articulo set Estado = 0 Where ArticuloID =" + ID;
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


        private void CmdLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {

        }

        
        private void txtDescripcion(object sender, EventArgs e)
        {

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtProveedor(object sender, EventArgs e)
        {

        }

        private void labelProveedor_Click(object sender, EventArgs e)
        {

        }

       
    }
}
