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
    public partial class EventoServicios : Form
    {

        private SqlCommand comando;
        private SqlDataAdapter adaptador;

        private SqlParameter param;
        private DataTable datos;

        private Servidor servidor;
        private string idEvento;
        private string idServicio, idServioTabla;

        private int canRestate,
                    canOriginal;

        public EventoServicios(string idEvento)
        {
            servidor = new Servidor();
            InitializeComponent();
            this.idEvento = idEvento;
        }

        private void listar()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "SELECT id_evento_servico, nombre, cantidad, cantidad_restante, Servicio.id_servicio FROM Evento_servicio_tabla, Servicio WHERE Evento_servicio_tabla.id_servicio=Servicio.id_servicio AND id_eventos=@id";

                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@id", idEvento);
                comando.Parameters.Add(param);

                adaptador = new SqlDataAdapter(comando);
                datos = new DataTable();

                adaptador.Fill(datos);
                dataGridViewEventoServicio.DataSource = datos;
                dataGridViewEventoServicio.Refresh();
                dataGridViewEventoServicio.AutoResizeColumns();
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

        private void EventoServicios_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void ActualizarServiciosEvento()
        {
            string respuesta, sql;
            try
            {

                servidor.AbrirConexin();
                sql = "UPDATE Evento_servicio_tabla SET cantidad=@can WHERE id_servicio=@id_servicio AND id_eventos=@id_eventos";
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@id_servicio", idServioTabla);
                comando.Parameters.Add(param);
                param = new SqlParameter("@id_eventos", idEvento);
                comando.Parameters.Add(param);
                param = new SqlParameter("@can", textBoxCantidad.Text);
                comando.Parameters.Add(param);


                comando.ExecuteNonQuery();
                respuesta = "Se ha editado el registro en Servicio";
            }
            catch (Exception error)
            {
                respuesta = "Error: " + error.Message;
            }
            finally
            {
                servidor.CerrarConexion();
            }
            MessageBox.Show(respuesta);
            listar();
        }

        private void ActualizarServicios(int NuevoValor)
        {
            string sql;
            try
            {

                servidor.AbrirConexin();

                sql = "Update Servicio Set cantidad_restante=@cant, disponibilidad=@dis Where id_servicio = @Id";
                comando = new SqlCommand(sql, servidor.SQLServer);

                param = new SqlParameter("@cant", NuevoValor);
                comando.Parameters.Add(param);
                param = new SqlParameter("@dis", NuevoValor > 0);
                comando.Parameters.Add(param);
                param = new SqlParameter("@Id", idServioTabla);
                comando.Parameters.Add(param);

                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                servidor.CerrarConexion();
            }
        }

        private void dataGridViewEventoServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewEventoServicio.Rows.Count - 1)
            {
                idServicio = dataGridViewEventoServicio.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewEventoServicio.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCantidad.Text = dataGridViewEventoServicio.Rows[e.RowIndex].Cells[2].Value.ToString();

                canRestate = Convert.ToInt32(dataGridViewEventoServicio.Rows[e.RowIndex].Cells[3].Value.ToString());
                canOriginal = Convert.ToInt32(dataGridViewEventoServicio.Rows[e.RowIndex].Cells[2].Value.ToString());

                idServioTabla = dataGridViewEventoServicio.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxCantidad.Text);
            if (n == canOriginal)
            {
                MessageBox.Show("Sin Cambios.");
                return;
            }

            if (n > canRestate)
            {
                MessageBox.Show("Error: No se puede agregar la cantidad " + n + "\n los servicios no son suficientes.");
            }
            else
            {
                if (n < canOriginal)
                {
                    canRestate = canRestate + (canOriginal - n);
                } else
                {
                    canRestate = canRestate - n;
                }

                if (canRestate < 0)
                {
                    MessageBox.Show("Error: No se puede agregar la cantidad " + n + "\n los servicios no son suficientes.");
                    return;
                }
                ActualizarServiciosEvento();
                ActualizarServicios(canRestate);
                listar();

                textBoxCantidad.Text = "";
                textBoxNombre.Text = "";
            }
        }
    }
}
