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
        Servidor servidor = new Servidor();
        public FormServicio()
        {
            InitializeComponent();
            
        }
      
        private void FormServicio_Load(object sender, EventArgs e)
        {
             buttonGuardar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonEditar.Enabled = false;
            groupBoxServicio.Enabled = false;
        }

        private void groupBoxServicio_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            servidor.AbrirConexin();
        }
    }
}
