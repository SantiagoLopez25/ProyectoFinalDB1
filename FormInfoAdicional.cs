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
    public partial class FormInfoAdicional : Form
    {

        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        public FormInfoAdicional()
        {
            InitializeComponent();
        }

        private void dataGridViewEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewEventos.Rows.Count - 1)
            {
                codigo = dataGridViewEventos.Rows[e.RowIndex].Cells[0].Value.ToString();
                llenarServicios();
                    
            }
        }

        private void FormInfoAdicional_Load(object sender, EventArgs e)
        {
            llenarEventos();
        }

        
        private void llenarServicios()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "select Servicio.id_servicio, Servicio.nombre, evento_servicio_tabla.cantidad from Evento_servicio_tabla, Servicio\r\nwhere Servicio.id_servicio = Evento_servicio_tabla.id_servicio\r\nand Evento_servicio_tabla.id_eventos = "+ codigo; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewServicios.DataSource = datos;
                dataGridViewServicios.Refresh();
                dataGridViewServicios.AutoResizeColumns();
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

        private void llenarEventos()
        {
            DateTime fecha = InfoAdicional.Fecha;

            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "select id_eventos, no_asistentes,  fecha_final as 'Fecha', Salon.nombre as 'Salon', Tipo_evento.nombre as 'Tipo' from Evento, Salon, Tipo_evento\r\nwhere (Evento.id_salon= Salon.id_salon and Evento.id_tipo = Tipo_evento.id_tipo) and Evento.fecha_final = '" + fecha.Year + "/" + fecha.Month + "/" + fecha.Day + "'"; //instruccion para listar el contenido de la tabla capacitador
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

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            //FormCalendarizacion reportes = new FormCalendarizacion();
            //reportes.Show();
            this.Close();
        }
    }
}
