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
using System.Security.Cryptography;

namespace ProyectoFinalDB1
{
    public partial class FormDigitador : Form
    {
        private Servidor servidor;

        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;

        private string id_encargado,
                        id_salon;

        public FormDigitador()
        {
            this.servidor = new Servidor();
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //                                               VERIFICACIÓN - SQL
        //--------------------------------------------------------------------------------------------------------------------------
        private bool DisponibleSalon()
        {
            try
            {
                servidor.AbrirConexin();
                string sql = "SELECT disponibilidad FROM Salon WHERE id_salon=@id_salon";

                comando = new SqlCommand(sql, this.servidor.SQLServer);

                param = new SqlParameter("@id_salon", id_salon);
                comando.Parameters.Add(param);

                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetBoolean(0);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                servidor.CerrarConexion();
            }
            return false;
        }

        private bool DisponibleServicio(Servicio s)
        {
            try
            {
                servidor.AbrirConexin();
                string sql = "SELECT cantidad_restante, disponibilidad FROM Servicio WHERE id_servicio=@id_servicio";

                comando = new SqlCommand(sql, this.servidor.SQLServer);

                param = new SqlParameter("@id_servicio", s.Id);
                comando.Parameters.Add(param);

                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    bool dis = dr.GetBoolean(1);
                    if (dis && (dr.GetInt32(0) - s.Cantidad) >= 0)
                    {
                        s.Calcular(dr.GetInt32(0));
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                servidor.CerrarConexion();
            }
            return false;
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //                                                  LISTAR - SQL
        //--------------------------------------------------------------------------------------------------------------------------
        private void ListarSalon()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "Select * From Salon"; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewSalon.DataSource = datos;
                dataGridViewSalon.Refresh();
                dataGridViewSalon.AutoResizeColumns();
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

        private void ListarPersonas()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "SELECT Encargado.id_encargado, Persona.nombre + ' '  + Persona.apellido AS nombre, Encargado.organizador, Encargado.responsable FROM Encargado, Persona WHERE  Encargado.id_persona=Persona.id_persona";
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewPersona.DataSource = datos;
                dataGridViewPersona.Refresh();
                dataGridViewPersona.AutoResizeColumns();
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

        private void ListarServicio()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "Select * From Servicio"; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewServicio.DataSource = datos;
                dataGridViewServicio.Refresh();
                dataGridViewServicio.AutoResizeColumns();
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

        private void ListarTipoEvento()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "SELECT * FROM Tipo_evento";

                comando = new SqlCommand(sql, servidor.SQLServer);
                adaptador = new SqlDataAdapter(comando);
                datos = new DataTable();
                adaptador.Fill(datos);

                comboBoxTipoEvento.DataSource = datos;
                comboBoxTipoEvento.DisplayMember = "nombre";
                comboBoxTipoEvento.ValueMember = "id_tipo";
                comboBoxTipoEvento.Refresh();
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

        private void ListarEventos()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "SELECT * FROM Evento";

                comando = new SqlCommand(sql, servidor.SQLServer);
                adaptador = new SqlDataAdapter(comando);
                datos = new DataTable();
                adaptador.Fill(datos);

                dataGridViewEventos.DataSource = datos;
                dataGridViewEventos.Refresh();
                dataGridViewEventos.AutoResizeColumns();
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

        //--------------------------------------------------------------------------------------------------------------------------
        //                                                 GUARDAR - SQL
        //--------------------------------------------------------------------------------------------------------------------------
        private void ActualizarGuardar()
        {
            ActualizarSalon();
            ActualizarServicios();

            GuardarEventoServicios(GuardarEvento());
            ListarEventos();
        }

        private void GuardarEventoServicios(int id_evento)
        {
            string sql, respuesta;
            try
            {
                servidor.AbrirConexin();
                for (int i = 0; i < comboBoxServicios.Items.Count; i++) 
                {
                    Servicio s = (Servicio) comboBoxServicios.Items[i];

                    sql = "INSERT INTO Evento_servicio_tabla (id_eventos, id_servicio, hora, fecha) VALUES (@id_eventos, @id_servicio, @hora, @fecha)";
                    comando = new SqlCommand(sql, servidor.SQLServer);

                    param = new SqlParameter("@id_eventos", id_evento);
                    comando.Parameters.Add(param);
                    param = new SqlParameter("@id_servicio", s.Id);
                    comando.Parameters.Add(param);

                    param = new SqlParameter("@hora", DateTime.Now.ToString("hh:mm:ss"));
                    comando.Parameters.Add(param);
                    param = new SqlParameter("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                    comando.Parameters.Add(param);
                    comando.ExecuteNonQuery();
                }
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

        public int GuardarEvento()
        {
            string sql, respuesta;
            try
            {
                servidor.AbrirConexin();
                sql = "INSERT INTO Evento (no_asistentes, descripcion, id_encargado, id_salon, id_tipo, hora_inicio, hora_final, fecha_inicio, fecha_final) VALUES (@no_asistentes, @descripcion, @id_encargado, @id_salon, @id_tipo, @hora_inicio, @hora_final, @fecha_inicio, @fecha_final)";
                comando = new SqlCommand(sql, servidor.SQLServer);

                param = new SqlParameter("@no_asistentes", textBoxAsistentes.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@descripcion", richTextBoxDescripcion.Text);
                comando.Parameters.Add(param);

                param = new SqlParameter("@id_encargado", id_encargado);
                comando.Parameters.Add(param);
                param = new SqlParameter("@id_salon", id_salon);
                comando.Parameters.Add(param);
                param = new SqlParameter("@id_tipo", comboBoxTipoEvento.SelectedValue);

                comando.Parameters.Add(param);
                param = new SqlParameter("@hora_inicio", DateTime.Parse(dateTimeInicio.Value.ToString()).ToString("hh:mm:ss"));
                comando.Parameters.Add(param);
                param = new SqlParameter("@hora_final", DateTime.Parse(dateTimeFinal.Value.ToString()).ToString("hh:mm:ss"));
                comando.Parameters.Add(param);
                param = new SqlParameter("@fecha_inicio", dateTimePickerInicio.Value.ToString("yyyy-MM-dd"));
                comando.Parameters.Add(param);
                param = new SqlParameter("@fecha_final", dateTimePickerFinal.Value.ToString("yyyy-MM-dd"));
                comando.Parameters.Add(param);

                comando.ExecuteNonQuery();


                int nid = -1;
                sql = "SELECT IDENT_CURRENT('Evento') AS ID_LAST";

                comando          = new SqlCommand(sql, this.servidor.SQLServer);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    nid = Convert.ToInt32(dr.GetValue(0).ToString());
                    
                }
                return nid;
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                servidor.CerrarConexion();
            }
            return -1;
        }

        private void ActualizarSalon()
        {
            string respuesta, sql;
            try
            {

                servidor.AbrirConexin();
                sql = "Update Salon Set disponibilidad=@dis Where id_salon = @Id";
                comando = new SqlCommand(sql, servidor.SQLServer);

                param = new SqlParameter("@dis", false);
                comando.Parameters.Add(param);

                param = new SqlParameter("@Id", id_salon);
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
            ListarSalon();
        }

        private void ActualizarServicios()
        {
            string respuesta, sql;
            try
            {

                servidor.AbrirConexin();

                for (int i = 0; i < comboBoxServicios.Items.Count; i++)
                {
                    sql = "Update Servicio Set cantidad_restante=@cant, disponibilidad=@dis Where id_servicio = @Id";
                    comando    = new SqlCommand(sql, servidor.SQLServer);
                    Servicio s = (Servicio) comboBoxServicios.Items[i];

                    param = new SqlParameter("@cant", s.NuevoValor);
                    comando.Parameters.Add(param);
                    param = new SqlParameter("@dis", s.NuevoValor > 0);
                    comando.Parameters.Add(param);
                    param = new SqlParameter("@Id", s.Id);
                    comando.Parameters.Add(param);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                servidor.CerrarConexion();
            }
            ListarServicio();
        }

        private void FormDigitador_Load(object sender, EventArgs e)
        {
            ListarPersonas();
            ListarSalon();
            ListarServicio();
            ListarTipoEvento();
            ListarEventos();
        }

        private void dataGridViewSalon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewSalon.Rows.Count - 1)
            {
                id_salon = dataGridViewSalon.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxSalon.Text = dataGridViewSalon.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewServicio.CurrentRow != null)
            {
                int index = dataGridViewServicio.CurrentRow.Index;

                Servicio s = new Servicio(dataGridViewServicio.Rows[dataGridViewServicio.CurrentRow.Index].Cells[0].Value.ToString(),
                                          dataGridViewServicio.Rows[dataGridViewServicio.CurrentRow.Index].Cells[1].Value.ToString(), Convert.ToInt32(textBoxCantidad.Text));

                if (DisponibleServicio(s))
                {
                    comboBoxServicios.Items.Add(s);
                    comboBoxServicios.DisplayMember = "Nombre";
                    comboBoxServicios.ValueMember = "Id";
                    comboBoxServicios.Refresh();

                    if (comboBoxServicios.Items.Count == 1)
                    {
                        comboBoxServicios.SelectedIndex = 0;
                    }

                    MessageBox.Show("Servicio Agregado: " + s.Nombre + ", Cantidad: " + s.Cantidad);
                } else
                {
                    MessageBox.Show("Servicios Agotado: " + s.Nombre);
                }
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (DisponibleSalon())
            {
                ActualizarGuardar();
            } else
            {
                MessageBox.Show("Salon no disponibles: " + textBoxSalon.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show(">> " + dateTimeFinal.Value.ToString("yyyy-MM-dd"));
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDigitador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogeo init = new FormLogeo();
            init.Show();

            Hide();
        }

        private void dataGridViewPersona_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPersona.Rows.Count - 1)
            {
                string id = dataGridViewPersona.Rows[e.RowIndex].Cells[0].Value.ToString(),
                       nombre = dataGridViewPersona.Rows[e.RowIndex].Cells[1].Value.ToString();

                id_encargado = id;
                textBoxResponsable.Text = nombre;
            }
        }
    }
}
