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
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;

        string IdFactura, IdEmpleado, IdArticulo;
        public GestionFacturacionArticulos()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            txtID.Text = "";
            cbxEmpleado.SelectedIndex = 0;
            cbxArticulo.SelectedIndex = 0;
            txtMonto.Text = "";
            txtUnidadVendida.Text = "";
            txtComentario.Text = "";
        }



        public void ActualizarTabla()
        {
            //dataGridView1.Rows.Clear();
            string dbString = "Select FacturaArticulo.FacturaID, Empleado.Nombre as 'Empleado', Articulo.Description as 'Articulo', FacturaArticulo.FechaVenta, FacturaArticulo.Monto, FacturaArticulo.UnidadVendida, FacturaArticulo.Comentario from FacturaArticulo inner join Empleado on FacturaArticulo.EmpleadoID = Empleado.EmpleadoID inner join Articulo on FacturaArticulo.ArticuloID = Articulo.ArticuloID where FacturaArticulo.Estado = 1";
          

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

        private void LlenarComboBoxEmpleado()
        {
            try
            {
                dbCafeteria.Open();
                string query = "Select EmpleadoID, Nombre from Empleado where Estado = 1";

                Command = new SqlCommand(query, dbCafeteria);
                dataAdapter = new SqlDataAdapter(Command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dbCafeteria.Close();

                cbxEmpleado.ValueMember = "EmpleadoID";
                cbxEmpleado.DisplayMember = "Nombre";
                cbxEmpleado.DataSource = dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LlenarComboBoxArticulo()
        {
            dbCafeteria.Open();
            string query = "Select ArticuloID, Description from Articulo";

            Command = new SqlCommand(query, dbCafeteria);
            dataAdapter = new SqlDataAdapter(Command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dbCafeteria.Close();

            cbxArticulo.ValueMember = "ArticuloID";
            cbxArticulo.DisplayMember = "Description";
            cbxArticulo.DataSource = dataTable;
        }

        private void GestionFacturacionArticulos_Load(object sender, EventArgs e)
        {
            LlenarComboBoxArticulo();
            LlenarComboBoxEmpleado();

            cbxArticulo.SelectedIndex = 0;
            cbxEmpleado.SelectedIndex = 0;

        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (IdFactura == null)
            {
                var EmpleadoID = Convert.ToInt32(IdEmpleado);
                var ArticuloID = Convert.ToInt32(IdArticulo);
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
                var id = IdFactura;
                var EmpleadoID = Convert.ToInt32(IdEmpleado);
                var ArticuloID = Convert.ToInt32(IdArticulo);
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

        private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdEmpleado = cbxEmpleado.SelectedValue.ToString();
        }

        private void cbxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdArticulo = cbxArticulo.SelectedValue.ToString();
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdFactura = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbxEmpleado.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbxArticulo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMonto.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtUnidadVendida.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtComentario.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        //Eliminar
        private void CmdEliminar(object sender, EventArgs e)
        {
           

            if(IdFactura == null)
            {
                MessageBox.Show("No has seleccionado una fila para eliminar");
            }
            else
            {
                var id = IdFactura;

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
