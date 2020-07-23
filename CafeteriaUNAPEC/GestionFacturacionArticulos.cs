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
    public partial class GestionFacturacionArticulos : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        public GestionFacturacionArticulos()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            txtID.Text = "";
            txtEmpleadoID.Text = "";
            txtArticuloID.Text = "";
            txtMonto.Text = "";
            txtUnidadVendida.Text = "";
            txtComentario.Text = "";
        }

        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from FacturaArticulo where Estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using(SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while(Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["FacturaID"].ToString(), Lector["EmpleadoID"].ToString(), Lector["ArticuloID"].ToString(), Lector["FechaVenta"].ToString(),
                    Lector["Monto"].ToString(), Lector["UnidadVendida"].ToString(), Lector["Comentario"].ToString());
                }
            }
            dbCafeteria.Close();
        }



        private void GestionFacturacionArticulos_Load(object sender, EventArgs e)
        {

        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                var EmpleadoID = Convert.ToInt32(txtEmpleadoID.Text);
                var ArticuloID = Convert.ToInt32(txtArticuloID.Text);
                string FechaVenta = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                var Monto = Convert.ToDouble(txtMonto.Text);
                var UnidadVendida = Convert.ToInt32(txtUnidadVendida.Text);
                var Comentario = txtComentario.Text;
                var Estado = "1";

                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into FacturaArticulo values('"+EmpleadoID+"', '"+ArticuloID+"', '"+FechaVenta+"', '"+Monto+"', '"+UnidadVendida+"', '"+Comentario+"','"+Estado+"')";
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
                var EmpleadoID = Convert.ToInt32(txtEmpleadoID.Text);
                var ArticuloID = Convert.ToInt32(txtArticuloID.Text);
                var Monto = Convert.ToDouble(txtMonto.Text);
                var UnidadVendida = Convert.ToInt32(txtUnidadVendida.Text);
                var Comentario = txtComentario.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update FacturaArticulo set EmpleadoID = '"+EmpleadoID+ "', ArticuloID = '"+ArticuloID+ "', Monto = '"+Monto+ "', UnidadVendida = '"+UnidadVendida+ "', Comentario = '"+ Comentario+ "' where FacturaID =" + id;
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
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEmpleadoID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtArticuloID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMonto.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtUnidadVendida.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtComentario.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        //Eliminar
        private void CmdEliminar(object sender, EventArgs e)
        {
           

            if(txtID.Text == "")
            {
                MessageBox.Show("No has seleccionado una fila para eliminar");
            }
            else
            {
                var id = txtID.Text;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update FacturaArticulo set Estado = 0 where FacturaID =" + id;
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
