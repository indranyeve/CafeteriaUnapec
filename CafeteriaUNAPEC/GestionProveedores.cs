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
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;
        string IdProveedor;

        public GestionProveedores()
        {
            InitializeComponent();
            ActualizarTabla();
            //MessageBox.Show((System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0])));
        }

        public void LimpiarCampos()
        {
            IdProveedor = null;
            txtNombreComercial.Text = "";
            txtRNC.Text = "";
        }

        public void ActualizarTabla()
        {
            //dataGridView1.Rows.Clear();
            string dbString = "Select * from Proveedor where Estado = 1";
            

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

        
        private void GestionProveedores_Load(object sender, EventArgs e)
        {

        }


        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if (IdProveedor == null)
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
                var ID = IdProveedor;
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
            IdProveedor = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombreComercial.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRNC.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        //Eliminar
        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (IdProveedor == null)
            {
                MessageBox.Show("No has seleccionado una fila para eliminar");
            }
            else
            {
                var ID = IdProveedor;
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


        /***************LLAMANDO STORE PROCEDURE*/

        //METODO EJERCUTAR STORE PROCEDURE
        public IEnumerable<T> EjecutarStoredProcedure<T>(string storedProcedure, string connectionString, SqlParameter[] parameters, Func<SqlDataReader, T> body)
        {
            List<T> results = new List<T>();

            using (dbCafeteria)
            {
                SqlCommand command = connection.CreateSPConnection(storedProcedure, connectionString);
                command.Parameters.AddRange(parameters);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(body(reader));
                }
                reader.Close();
            }
            return results;
        }

        //REFERENCIAR STORE PROCEDURE
        public IEnumerable<UserEntity> GetUser()
        {
            try
            {
                return ProceduresExecution.Instance.EjecutarStoredProcedure<UserEntity>("NombreStoredProcedure",
                    GlobalData.ConnectionStringDefault,
                    new SqlParameter[]{
                new SqlParameter("@inUserId", 123),
                new SqlParameter("@OtroParametro", "OtroParametro")
                    },
                    reader =>
                    {
                        return new UserEntity
                        {
                    //En esta sección van todas las propiedades de la Entidad UserEntity y ["Aqui"] van mapeados a los nombres de las columnas que recuperaste en la consulta de base de datos
                    UserId = (int)reader["UserId"],
                            Nombre = reader["Nombre"].ToString()
        
                            UserTypeId = (int)reader["UserTypeId"]
                        };
                    });
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el usuario" + ex.message);
            }
        }

        new SqlParameter[] 
        {
            new SqlParameter("@inUserId", 123),
            new SqlParameter("@OtroParametro", "OtroParametro")
        }


}
}
