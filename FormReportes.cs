using ProyectoFinalDB1.Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinalDB1
{
    public partial class FormReportes : Form
    {
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        private Usuario usuario;
        private Dictionary<string, Form> ventanas;
        string Formulario;
        public FormReportes()
        {
            InitializeComponent();
           
        }
        public void SetUsuario(string nombre, int pirvilegios)
        {
            this.usuario = new Usuario();
            this.usuario.Nombre = nombre;
            this.usuario.Privilegios = pirvilegios;

            this.Text = "Home " + nombre;
            this.labelUsuario.Text = "Bienvenido [ " + nombre + " ]";
        }
        private void FormReportes_Load(object sender, EventArgs e)
        {
            Formulario = radioButtonEspacios.Text;
            this.ventanas = new Dictionary<string, Form>();
            ventanas.Add(radioButtonFecha.Text, new FormBusFecha());
            ventanas.Add(radioButtonEspacios.Text, new FormCantidadSalones());
            ventanas.Add(radioButtonApellido.Text, new FormBusOrganizador());
            ventanas.Add(radioButtonCalendarizacion.Text, new FormCalendarizacion());

            // ventanas.Add(radioButtonTipoSalon.Text, new FormTipoSalon());
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = null;

            FormLogeo init = new FormLogeo();
            init.Show();

            Hide();
        }

        private void dataGridViewEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form window = this.ventanas[Formulario];
            if (window != null)
            {
                window.ShowDialog();
                
            }
        }

        private void radioButtonEspacios_CheckedChanged(object sender, EventArgs e)
        {
            Formulario = radioButtonEspacios.Text;
        }

        private void radioButtonApellido_CheckedChanged(object sender, EventArgs e)
        {
            Formulario = radioButtonApellido.Text;
        }

        private void radioButtonFecha_CheckedChanged(object sender, EventArgs e)
        {
            Formulario = radioButtonFecha.Text;
        }

        private void radioButtonCalendarizacion_CheckedChanged(object sender, EventArgs e)
        {
            Formulario = radioButtonCalendarizacion.Text;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            usuario = null;
            Application.Exit();
        }
    }
}
