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
    public partial class GestionUsuarios : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;
        String IdTipoDeUsuarios, IdUsuarios;
        public GestionUsuarios()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            LlenarComboboxTipoDeUsuario();
            cbxTipoDeUsuario.SelectedIndex = 0;
        }

        public void LimpiarCampos()
        {
            IdUsuarios = null;
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtLimiteCredito.Text = "";
            cbxTipoDeUsuario.SelectedIndex = 0;
        }

        public void ActualizarTabla()
        {
           // dataGridView1.Rows.Clear();
            string dbString = "select Usuario.UsuarioID, Usuario.Nombre, Usuario.Cedula, TipoDeUsuario.Descripcion as 'Tipo de Usuario', Usuario.LimiteCredito, Usuario.FechaRegistro from Usuario inner join TipoDeUsuario on Usuario.TipoDeUsuarioID = TipoDeUsuario.TipoDeUsuarioID where Usuario.Estado = 1";

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

        private void LlenarComboboxTipoDeUsuario()
        {
            try
            {
                dbCafeteria.Open();
                string query = "select TipoDeUsuarioID, Descripcion from TipoDeUsuario where Estado = 1";

                Command = new SqlCommand(query, dbCafeteria);
                dataAdapter = new SqlDataAdapter(Command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dbCafeteria.Close();

                cbxTipoDeUsuario.ValueMember = "TipoDeUsuarioID";
                cbxTipoDeUsuario.DisplayMember = "Descripcion";
                cbxTipoDeUsuario.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (IdUsuarios == null)
            {

                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var TipoDeUsuario = Convert.ToInt32(IdTipoDeUsuarios);
                var LimiteCredito = (txtLimiteCredito.Text == "") ? 0 : Convert.ToInt32(txtLimiteCredito.Text); 
                 var FechaRegistro = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                var Estado = "1";

                UsuariosValidacion validador = new UsuariosValidacion(Nombre, Cedula, LimiteCredito, TipoDeUsuario);
                validador.validar();
                bool isValidModel = validador.boolean;

                if (isValidModel == true)
                {
                    try
                    {
                        dbCafeteria.Open();
                        string dbString = "insert into Usuario values ('" + Nombre + "', '" + Cedula + "', '" + TipoDeUsuario + "', '" + LimiteCredito + "', '" + FechaRegistro + "', '" + Estado + "')";
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
                var id = IdUsuarios;
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var TipoDeUsuario = IdTipoDeUsuarios;
                var LimiteCredito = txtLimiteCredito.Text;
                

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Usuario set Nombre = '" + Nombre + "', Cedula = '" + Cedula + "', TipoDeUsuarioID ='"+ TipoDeUsuario+ "', LimiteCredito = '"+ LimiteCredito +"' where UsuarioID =" + id;

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
        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

       

        //Eliminar
        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (IdUsuarios == null)
            {
                MessageBox.Show("No haz seleccionado una fila para eliminar");
            }
            else
            {
                var id = IdUsuarios;

                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Usuario set Estado = 0 Where UsuarioID =" + id;
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

        private void cbxTipoDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdTipoDeUsuarios = cbxTipoDeUsuario.SelectedValue.ToString();
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdUsuarios = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCedula.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxTipoDeUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLimiteCredito.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
