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
    public partial class FormCalendarizacion : Form
    {
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private DataColumn datosColumn;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        List<DateTime> fechas = new List<DateTime>();
        DateTime mesActual;
        //private List<DateTime> fechasSeleccionadas;
        
        public FormCalendarizacion()
        {
            InitializeComponent();
            mesActual = DateTime.Today;
            // Configurar el MonthCalendar
            // monthCalendar1.DateSelected += MonthCalendar1_DateSelected;


        }

        private void FormCalendarizacion_Load(object sender, EventArgs e)
        {
            string respuesta, sql;
            try
            {

                servidor.AbrirConexin();
                sql = "select fecha_final from Evento"; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridView1.DataSource = datos;
                dataGridView1.Refresh();
                dataGridView1.AutoResizeColumns();

            }
            catch (Exception error)
            {
                respuesta = "Error: " + error.Message;
            }
            finally
            {
                servidor.CerrarConexion();
            }

            int cantidad = dataGridView1.RowCount;
            for (int i = 0; i < cantidad; i++)
            {

                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    DateTime fechaEvento = (DateTime)(dataGridView1.Rows[i].Cells[0].Value);

                    fechas.Add(fechaEvento);
                    monthCalendar1.AddBoldedDate(fechaEvento);
                }

            }
            monthCalendar1.UpdateBoldedDates();

           




        }

       




        private void buttonVer_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        


            if((mesActual.Month == monthCalendar1.SelectionStart.Month) && (mesActual.Year == monthCalendar1.SelectionStart.Year))
            {
                if (fechas.Contains(monthCalendar1.SelectionStart))
                {
                    

                    InfoAdicional.Fecha = monthCalendar1.SelectionStart;
                    FormInfoAdicional info = new FormInfoAdicional();
                    info.ShowDialog();
                }
               

            }

            mesActual = monthCalendar1.SelectionStart;




        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
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
