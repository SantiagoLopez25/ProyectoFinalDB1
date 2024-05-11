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
    public partial class FormPantallaEmpleado : Form
    {
        private Usuario usuario;

        public FormPantallaEmpleado()
        {
            InitializeComponent();
        }

        public void SetUsuario(string nombre, int pirvilegios)
        {
            this.usuario = new Usuario();
            this.usuario.Nombre = nombre;
            this.usuario.Privilegios = pirvilegios;

            this.Text = "Home " + nombre;
            this.label2.Text = "[ " + nombre + " ]";
        }

        private void FormPantallaEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = null;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuario = null;

            FormLogeo init = new FormLogeo();
            init.Show();

            Hide();
        }
    }
}
