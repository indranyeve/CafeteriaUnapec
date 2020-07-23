using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUNAPEC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultaEmpleados_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            //Buton de salida (evento)
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btnConsultaEmpleados_Click_1(object sender, EventArgs e)
        {
            //Llamando al CRUD de Empleados
            Empleados form = new Empleados();
            form.Show();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe form = new AcercaDe();
            form.Show();
            
        }

        private void btnConsultaTDU_Click(object sender, EventArgs e)
        {
            TipoDeUsuario form = new TipoDeUsuario();
            form.Show();
        }

        private void btnConsultaMarcas_Click(object sender, EventArgs e)
        {
            GestionMarcas form = new GestionMarcas();
            form.Show();
        }

        private void btnConsultaCampus_Click(object sender, EventArgs e)
        {
            GestionCampus form = new GestionCampus();
            form.Show();
        }

        private void btnConsultaArticulos_Click(object sender, EventArgs e)
        {
            GestionArticulos form = new GestionArticulos();
            form.Show();
        }

        private void btnConsultaProveedores_Click(object sender, EventArgs e)
        {
            GestionProveedores form = new GestionProveedores();
            form.Show();
        }

        private void btnConsultaCafeterias_Click(object sender, EventArgs e)
        {
            GestionCafeteria form = new GestionCafeteria();
            form.Show();
        }

        private void btnConsultaUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuarios form = new GestionUsuarios();
            form.Show();
        }

        private void btnFacturaciónArticulos_Click(object sender, EventArgs e)
        {

        }
    }
}
