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
    public partial class FormLogeo : Form
    {
        private Servidor servidor;

        public FormLogeo()
        {
            InitializeComponent();
            ComponentesAdicionales();
        }

        private void ComponentesAdicionales()
        {
            servidor = new Servidor();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
