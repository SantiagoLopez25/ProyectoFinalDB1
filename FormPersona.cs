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
    public partial class FormPersona : Form
    {

        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        public FormPersona()
        {
            InitializeComponent();
           
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
           
            buttonEliminar.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = false;
            groupBoxPersona.Enabled = false;
            listar();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
            groupBoxPersona.Enabled = true;
            limpiar();
        }

        private void limpiar()
        {
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";
            txtApellido.Text = "";
            checkBox1.Checked = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string sql, respuesta;



            try
            {
                servidor.AbrirConexin();
                sql = "Insert Into Persona (nombre, apellido, telefono, activo) Values(@nom, @ape, @tel, @act)"; //instruccion para insertar
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@ape", txtApellido.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@tel", textBoxTelefono.Text);
                comando.Parameters.Add(param);

                param = new SqlParameter("@act", checkBox1.Checked);
                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();
                respuesta = "Se ha creado un nuevo registro en Persona";
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
            groupBoxPersona.Enabled = false;
            limpiar();
            listar();
        }

        private void dataGridViewPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPersona.Rows.Count - 1)
            {
                codigo = dataGridViewPersona.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewPersona.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtApellido.Text = dataGridViewPersona.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxTelefono.Text = dataGridViewPersona.Rows[e.RowIndex].Cells[4].Value.ToString();
                checkBox1.Checked = (bool)(dataGridViewPersona.Rows[e.RowIndex].Cells[3].Value);



                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = false;
                groupBoxPersona.Enabled = true;


            }
        }

        private void listar()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "Select * From Persona"; //instruccion para listar el contenido de la tabla capacitador
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
        private void buttonListar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string respuesta, sql;
            try
            {

                servidor.AbrirConexin();
                sql = "Update Persona Set nombre = @nom, apellido = @ape, telefono = @tel, activo = @act Where id_persona = @Id";
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@ape", txtApellido.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@tel", textBoxTelefono.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@act", checkBox1.Checked);
                comando.Parameters.Add(param);
                param = new SqlParameter("@Id", codigo);
                comando.Parameters.Add(param);


                comando.ExecuteNonQuery();
                respuesta = "Se ha editado el registro en Servicio";
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
            groupBoxPersona.Enabled = false;
            limpiar();
            listar();
        }
    }
}
