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
    public partial class Empleados : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand Command;

        string IdEmpleado, TandaLabor;
        public Empleados()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            TandaLabor = null;
            txtPorcientoComision.Text = "";
            IdEmpleado = null;
        }
        public void ActualizarTabla()
        {
            //dataGridView1.Rows.Clear();
            string dbString = "Select * from Empleado where Estado = 1";
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
            if(IdEmpleado == null)
            {
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                TandaLabor += (radioButtonMatutina.Checked) ? radioButtonMatutina.Text : "";
                TandaLabor += (radioButtonVespertina.Checked) ? radioButtonVespertina.Text : "";
                TandaLabor += (radioButtonNocturna.Checked) ? radioButtonNocturna.Text : "";

                var PorcientajeComision = (txtPorcientoComision.Text=="")?0: Convert.ToInt32(txtPorcientoComision.Text);
                string FechaIngreso = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                var Estado = "1";

                EmpleadoValidacion validador = new EmpleadoValidacion(Nombre, Cedula, PorcientajeComision, TandaLabor);
                validador.validar();
                bool isValidModel = validador.boolean;
                if (isValidModel == true)
                {
                    try
                    {
                        dbCafeteria.Open();
                        string dbString = "insert into Empleado values('" + Nombre + "', '" + Cedula + "', '" + TandaLabor + "', '"
                            + PorcientajeComision + "', '" + FechaIngreso + "', '" + Estado + "')";
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
                var ID = IdEmpleado;
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                TandaLabor += (radioButtonMatutina.Checked) ? radioButtonMatutina.Text : "";
                TandaLabor += (radioButtonVespertina.Checked) ? radioButtonVespertina.Text : "";
                TandaLabor += (radioButtonNocturna.Checked) ? radioButtonNocturna.Text : "";

                var PorcientajeComision = Convert.ToInt32(txtPorcientoComision.Text);
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Empleado set Nombre = '"+Nombre+"', Cedula = '"+Cedula+"', TandaLabor = '"+TandaLabor+ "',  PorcentajeComision = '" + PorcientajeComision + "' where EmpleadoID ="+ID;
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
            IdEmpleado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCedula.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            string _TandaLabor = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            radioButtonMatutina.Checked = (_TandaLabor == radioButtonMatutina.Text) ? true : false;
            radioButtonVespertina.Checked = (_TandaLabor == radioButtonVespertina.Text) ? true : false;
            radioButtonNocturna.Checked = (_TandaLabor == radioButtonNocturna.Text) ? true : false;

            txtPorcientoComision.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        //Eliminar
        private void CmdEliminar(object sender, EventArgs e)
        {
            if (IdEmpleado == null)
            {
                MessageBox.Show("No has seleccionado una fila para eliminar");
            }
            else
            {
                var ID = IdEmpleado;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Empleado set Estado = 0 where EmpleadoID =" + ID;
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar un registro");
                    
                }
            }
        }
        private void CmdEditar_Click(object sender, EventArgs e)
        {

        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelTandaLabor_Click(object sender, EventArgs e)
        {

        }

        private void txtTandaLabor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPorcientoComision_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

           private void txtBusquedaPorNombre_KeyUp(object sender, KeyEventArgs e)
          {
              
          }

    }
}

