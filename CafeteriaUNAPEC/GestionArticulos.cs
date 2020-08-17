
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CafeteriaUNAPEC.VALICADIONES;
using CafeteriaUNAPEC.VALICADIONES.ValidacionesEntidades;


namespace CafeteriaUNAPEC
{
    public partial class GestionArticulos: Form

    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;

        string IdMarca, IdProveedor, IdArticulo;

        public GestionArticulos()
        {
            InitializeComponent();
            ActualizarTabla();

        }

        public void LimpiarCampos()
        {
            txtDescription.Text = "";
            txtCosto.Text = "";
            txtExistencia.Text = "";
            cbxProveedor.SelectedIndex = 0;
            cbxMarca.SelectedIndex = 0;
            IdArticulo = null;
        }

        public void ActualizarTabla()
        {
           // dataGridView2.Rows.Clear();
            
            string dbString = "select articulo.ArticuloID, articulo.Description as 'Descripcion', articulo.Costo, Proveedor.NombreComercial as 'Proveedor', Marca.Descripcion as 'Marca', articulo.Existencia from articulo inner join Proveedor on articulo.ProveedorID = Proveedor.ProveedorID inner join Marca on articulo.MarcaID = Marca.MarcaID where Articulo.Estado = 1";

            try
            {
                dataAdapter = new SqlDataAdapter(dbString, dbCafeteria);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void LlenarComboboxProveedor()
        {

            try
            {
                dbCafeteria.Open();
                string query = "select ProveedorId, NombreComercial from Proveedor where Estado = 1";

                Command = new SqlCommand(query, dbCafeteria);
                dataAdapter = new SqlDataAdapter(Command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dbCafeteria.Close();

                cbxProveedor.ValueMember = "ProveedorId";
                cbxProveedor.DisplayMember = "NombreComercial";
                cbxProveedor.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void LlenarComboboxMarca()
        {

            try
            {
                dbCafeteria.Open();
                string query = "select MarcaId, Descripcion from Marca where Estado = 1";

                Command = new SqlCommand(query, dbCafeteria);
                dataAdapter = new SqlDataAdapter(Command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                               
                dbCafeteria.Close();

                cbxMarca.ValueMember = "MarcaId";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (IdArticulo == null)
            {
                string Descripcion = txtDescription.Text;
                int Costo = (txtCosto.Text == "") ? 0 : Convert.ToInt32(txtCosto.Text);
                int Proveedor = Convert.ToInt32(IdProveedor);
                int Marca = Convert.ToInt32(IdMarca);
                int Existencia = (txtExistencia.Text == "") ? 0 : Convert.ToInt32(txtExistencia.Text);
                int Estado = 1;

                ArticuloValidacion validador = new ArticuloValidacion(Descripcion, Costo, Proveedor, Marca, Existencia);
                validador.validar();
                bool isValidModel = validador.boolean;

                if(isValidModel == true)
                {
                    try
                    {
                        dbCafeteria.Open();
                        string dbString = "insert into Articulo values('" + Descripcion + "', '" + Costo + "', '" + Proveedor + "','" + Marca + "', '"
                            + Existencia + "', '" + Estado + "')";
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
                var ID = IdArticulo;
                var Descripcion = txtDescription.Text;
                var Costo = txtCosto.Text;
                var Proveedor = IdProveedor;
                var Marca = IdMarca;
                var Existencia = txtExistencia.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Articulo set Description = '" + Descripcion + "', Costo = '" + Costo + "', ProveedorID = '" + Proveedor + "', MarcaID = '" + Marca + "', Existencia ='" + Existencia + "' where ArticuloID =" + ID;
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

       


        //Eliminar
        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (IdArticulo == null)
            {
                MessageBox.Show("No haz seleccionado una fila para eliminar");
            }
            else
            {
                var ID = IdArticulo;
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

            LlenarComboboxProveedor();
            LlenarComboboxMarca();

            cbxProveedor.SelectedIndex = 0;
            cbxMarca.SelectedIndex = 0;

        }
        
        private void txtDescripcion(object sender, EventArgs e)
        {

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }


        private void labelProveedor_Click(object sender, EventArgs e)
        {

        }

        //Evento Recoger Datos de la Fila
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdArticulo = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCosto.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxProveedor.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxMarca.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtExistencia.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            IdMarca = cbxMarca.SelectedValue.ToString();
        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            IdProveedor = cbxProveedor.SelectedValue.ToString();
        }


        //


    }
}
