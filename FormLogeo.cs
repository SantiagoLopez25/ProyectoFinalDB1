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

namespace ProyectoFinalDB1
{
    public partial class FormLogeo : Form
    {
        private Servidor servidor;
        private SqlCommand comando;
        private SqlParameter param;

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

                string sql = "SELECT id_usuario, Rol.nivel_privilegio FROM Usuario, Rol WHERE nombre_usuario=@user AND contrasennia=@pass AND Usuario.id_rol=Rol.id_rol";

                comando = new SqlCommand(sql, this.servidor.SQLServer);

                param = new SqlParameter("@user", user.Text);
                comando.Parameters.Add(param);

                param = new SqlParameter("@pass", pass.Text);
                comando.Parameters.Add(param);

                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    int idUser = dr.GetInt32(0);
                    string nivelPrivilegio = dr.GetString(1);

                    // Dependiendo del nivel de privilegio del usuario; iniciará sesión en un formulario (ventana)
                    // diferente y única.

                    // El nivel de privilegios '0' es el usuario con el poder sobre toda la base de datos que
                    // utiliza este sistema. MUY AL ESTILO DE LINUX ;) ....
                    if (Convert.ToInt32(nivelPrivilegio) == 0)
                    {
                        FormPantallaAdmin winRoot = new FormPantallaAdmin();
                        winRoot.SetUsuario(user.Text, Convert.ToInt32(nivelPrivilegio));
                        winRoot.Show();                        
                    }
                    else if (Convert.ToInt32(nivelPrivilegio) == 1)
                    {
                        FormReportes winDef = new FormReportes();
                        winDef.SetUsuario(user.Text, Convert.ToInt32(nivelPrivilegio));
                        winDef.Show();
                    }
                    else
                    {
                        FormDigitador winDidit = new FormDigitador();
                        winDidit.Show();
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

        private void FormLogeo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
