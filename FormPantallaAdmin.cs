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

namespace ProyectoFinalDB1
{
    public partial class FormPantallaAdmin : Form
    {
        private Usuario usuario;
        private Dictionary<string, Form> ventanas;

        private string nombreForm;
        
        public FormPantallaAdmin()
        {
            InitializeComponent();
            this.ventanas = new Dictionary<string, Form>();
            this.nombreForm = radioButtonPersona.Text;

            this.ventanas.Add(radioButtonPersona.Text, new FormPersona());
            this.ventanas.Add(radioButtonSalon.Text, new FormSalon());
            this.ventanas.Add(radioButtonServicio.Text, new FormServicio());
            this.ventanas.Add(radioButtonTipoSalon.Text, new FormTipoSalon());
        }

        public void SetUsuario(string nombre, int pirvilegios)
        {
            this.usuario = new Usuario();
            this.usuario.Nombre = nombre;
            this.usuario.Privilegios = pirvilegios;

            this.Text = "Home " + nombre;
            this.label1.Text = "Bienvenido [ " + nombre+  " ]";
        }

        private void FormPantallaAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = null;

            FormLogeo init = new FormLogeo();
            init.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form window = this.ventanas[this.nombreForm];
            if (window != null)
            {
                window.ShowDialog();
            }
        }

        private void radioButtonPersona_CheckedChanged(object sender, EventArgs e) { this.nombreForm = radioButtonPersona.Text; }
        private void radioButtonServicio_CheckedChanged(object sender, EventArgs e) { this.nombreForm = radioButtonServicio.Text; }
        private void radioButtonTipoSalon_CheckedChanged(object sender, EventArgs e) { this.nombreForm = radioButtonTipoSalon.Text; }
        private void radioButtonSalon_CheckedChanged(object sender, EventArgs e) { this.nombreForm = radioButtonSalon.Text;  }

        private void button3_Click(object sender, EventArgs e)
        {
            usuario = null;
            Application.Exit();
        }
    }
}
