using ProyectoFinalDB1.Sys;
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

namespace ProyectoFinalDB1
{
    public partial class FormLogeo : Form
    {
        private Servidor servidor;
        private SqlCommand comando;

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

            try
            {
                servidor.AbrirConexin();

                string sql = "SELECT id_usuario, Rol.nivel_privilegio FROM Usuario, Rol WHERE nombre_usuario=@user AND contrasennia=@pass";

                comando = new SqlCommand(sql, this.servidor.SQLServer);
                comando.Parameters.Add("@user", user.Text);
                comando.Parameters.Add("@pass", pass.Text);

                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    int idUser = dr.GetInt32(0);
                    string nivelPrivilegio = dr.GetString(1);

                    if (Convert.ToInt32(nivelPrivilegio) > 0)
                    {
                        FormPantallaEmpleado winDef = new FormPantallaEmpleado();
                        winDef.Show();
                    }
                    else
                    {
                        FormPantallaAdmin winRoot = new FormPantallaAdmin();
                        winRoot.Show();
                    }
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario inválido: " + user.Text);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("[ ERROR ] :No se puede gestionar los datos con el servidor > " + ex.Message);
            }
            finally
            {
                servidor.CerrarConexion();
            }

        }
    }
}
