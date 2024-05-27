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
    public partial class FormBusOrganizador : Form
    {
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        
        private string codigo;
        private string codigo_encargado;
        Servidor servidor = new Servidor();

       
        public FormBusOrganizador()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string apellido = textBoxApellido.Text;
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "select\tpersona.id_persona, apellido, nombre, Encargado.id_encargado\tfrom persona, Encargado\r\nwhere Encargado.id_persona = Persona.id_persona\r\nand apellido like '%"+apellido+"%'"; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewOrganizador.DataSource = datos;
                dataGridViewOrganizador.Refresh();
                dataGridViewOrganizador.AutoResizeColumns();

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

        private void infoPersonal()
        {
            string respuesta, sql;
            try
            {
              
                servidor.AbrirConexin();
                sql = "select persona.id_persona, apellido, nombre, telefono, zona, ciudad from persona, direccion\r\nwhere Direccion.id_persona = Persona.id_persona and Persona.id_persona = "+codigo; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewInformacionP.DataSource = datos;
                dataGridViewInformacionP.Refresh();
                dataGridViewInformacionP.AutoResizeColumns();

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

        private void eventos()
        {
            string respuesta, sql;
            try
            {

                servidor.AbrirConexin();
                sql = "select id_eventos, no_asistentes, fecha_final, Salon.nombre as 'Salon', Tipo_evento.nombre as 'Tipo' from Evento, Salon, Tipo_evento\r\nwhere (Evento.id_salon= Salon.id_salon and Evento.id_tipo = Tipo_evento.id_tipo) and Evento.id_encargado = " + codigo_encargado; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewEventos.DataSource = datos;
                dataGridViewEventos.Refresh();
                dataGridViewEventos.AutoResizeColumns();

                int cantidad = dataGridViewEventos.RowCount;
                for (int i = 0; i < cantidad; i++)
                {
                   
                    if(dataGridViewEventos.Rows[i].Cells[2].Value != null)
                    {
                        DateTime fechaEvento = (DateTime)(dataGridViewEventos.Rows[i].Cells[2].Value);

                        
                        if (fechaEvento < DateTime.Today)
                        //if(resultado > 0)
                        {

                            dataGridViewEventos.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else 
                        {
                            dataGridViewEventos.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                        }
                    }
                    
                }

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

        private void dataGridViewOrganizador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewOrganizador.Rows.Count - 1)
            {
                codigo = dataGridViewOrganizador.Rows[e.RowIndex].Cells[0].Value.ToString();
                codigo_encargado = dataGridViewOrganizador.Rows[e.RowIndex].Cells[3].Value.ToString();
                infoPersonal();
                eventos();

              


            }
        }

        private void dataGridViewInformacionP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBusOrganizador_Load(object sender, EventArgs e)
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
