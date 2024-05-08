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
        public FormPantallaAdmin()
        {
            InitializeComponent();
        }

        private void FormPantallaAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
