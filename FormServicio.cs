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
    public partial class FormServicio : Form
    {
        public FormServicio()
        {
            InitializeComponent();
            componentesAdicionales();
        }
        private void componentesAdicionales()
        {
            Servidor servidor = new Servidor();
        }

        private void FormServicio_Load(object sender, EventArgs e)
        {
             buttonGuardar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonEditar.Enabled = false;
            groupBoxServicio.Enabled = false;
        }
    }
}
