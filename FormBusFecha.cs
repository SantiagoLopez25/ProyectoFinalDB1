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
    public partial class FormBusFecha : Form
    {
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        public FormBusFecha()
        {
            InitializeComponent();
        }

        private void FormBusFecha_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime fecha = dateTimePicker1.Value.Date;

            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "select id_eventos, no_asistentes, fecha_final, Salon.nombre as 'Salon', Tipo_evento.nombre as 'Tipo' from Evento, Salon, Tipo_evento\r\nwhere (Evento.id_salon= Salon.id_salon and Evento.id_tipo = Tipo_evento.id_tipo) and Evento.fecha_final = '" + fecha.Year + "/" + fecha.Month + "/" + fecha.Day + "'"; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewEventos.DataSource = datos;
                dataGridViewEventos.Refresh();
                dataGridViewEventos.AutoResizeColumns();
            }
            catch (Exception error)
            {
                respuesta = "Error: " + error.Message;
            }
            finally
            {
                servidor.CerrarConexion();
            }
        }

        private void dataGridViewEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            //FormReportes reportes = new FormReportes();

            //reportes.Show();
            this.Close();
        }
    }
}
