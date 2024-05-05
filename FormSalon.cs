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
    public partial class FormSalon : Form
    {
        public FormSalon()
        {
            InitializeComponent();
            
        }

      

        private void FormSalon_Load(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = false;
            groupBoxSalon.Enabled = false;
        }
    }
}
