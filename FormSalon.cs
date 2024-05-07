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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalDB1
{
    public partial class FormSalon : Form
    {

        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
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
            llenarComboBox();
            listar();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
            groupBoxSalon.Enabled = true;
            limpiar();
        }

        private void limpiar()
        {
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            llenarComboBox();
            comboBoxTamannio.SelectedIndex = 0;
            checkBox1.Checked = false;
        }

        void llenarComboBox()
        {
            string sql;

            try
            {
                sql = "Select id_tipo, nombre from tipo_salon"; //instruccion paralistar el contenido de la tabla persona
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                comboBoxTipoSalon.DataSource = datos;
                comboBoxTipoSalon.DisplayMember = "nombre";
                comboBoxTipoSalon.ValueMember = "id_tipo";
                comboBoxTipoSalon.Refresh();

            }
            finally
            {
                servidor.CerrarConexion();
            }

            //MessageBox.Show(respuesta);

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string sql, respuesta;



            try
            {
                servidor.AbrirConexin();
                sql = "Insert Into Salon (nombre, disponibilidad, tamannio, direccion, id_tipo) Values(@nom, @dis, @tam, @dir, @tip)"; //instruccion para insertar
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@dis", checkBox1.Checked);
                comando.Parameters.Add(param);

                param = new SqlParameter("@tam", comboBoxTamannio.SelectedItem);
                comando.Parameters.Add(param);
                param = new SqlParameter("@dir", textBoxDireccion.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@tip", comboBoxTipoSalon.SelectedIndex + 1);

                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();
                respuesta = "Se ha creado un nuevo registro en Servicio";
            }

            catch (Exception error)
            {
                respuesta = "Error: " + error.Message;
            }
            finally
            {
                servidor.CerrarConexion();
            }
            buttonGuardar.Enabled = false;
            MessageBox.Show(respuesta);
            limpiar();
            groupBoxSalon.Enabled = false;
            listar();
        }

        private void listar()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "select salon.id_salon, salon.nombre, direccion, tamannio as tamaño, disponibilidad, Tipo_salon.nombre as tipo from salon, tipo_salon where salon.id_tipo = Tipo_salon.id_tipo"; //instruccion para listar el contenido de la tabla capacitador
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

        private void buttonListar_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewSalon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewSalon.Rows.Count - 1)
            {
                //llenarComboBox();
                codigo = dataGridViewSalon.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewSalon.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxDireccion.Text = dataGridViewSalon.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxTamannio.SelectedItem = dataGridViewSalon.Rows[e.RowIndex].Cells[3].Value.ToString();
                checkBox1.Checked = (bool)(dataGridViewSalon.Rows[e.RowIndex].Cells[4].Value);
                //MessageBox.Show(dataGridViewSalon.Rows[e.RowIndex].Cells[5].Value.ToString());

               //for (int i = 0; i < comboBoxTipoSalon.Items.Count; i++)
               // {
               //     comboBoxTipoSalon.SelectedIndex = i;
               //     if(comboBoxTipoSalon.SelectedItem == dataGridViewSalon.Rows[e.RowIndex].Cells[5].Value.ToString())
               //     {
               //         break;
               //     }
               // }

                comboBoxTipoSalon.SelectedItem = dataGridViewSalon.Rows[e.RowIndex].Cells[5].Value.ToString();



                buttonEditar.Enabled = true;
                //buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = false;
                groupBoxSalon.Enabled = true;


            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string respuesta, sql;
            try
            {

                servidor.AbrirConexin();
                sql = "Update Salon Set nombre = @nom, direccion = @dir, tamannio = @tam, disponibilidad = @dis, id_tipo = @tip Where id_salon = @Id";
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@dir", textBoxDireccion.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@tam", comboBoxTamannio.SelectedItem);
                comando.Parameters.Add(param);
                param = new SqlParameter("@dis", checkBox1.Checked);
                comando.Parameters.Add(param);
                param = new SqlParameter("@tip", comboBoxTipoSalon.SelectedIndex + 1);
                comando.Parameters.Add(param);

                param = new SqlParameter("@Id", codigo);
                comando.Parameters.Add(param);


                comando.ExecuteNonQuery();
                respuesta = "Se ha editado el registro en Salón";
                // MessageBox.Show(respuesta, "Registro editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonEditar.Enabled = false;
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
            limpiar();
            groupBoxSalon.Enabled = false;
            listar();
        }
    }
}
