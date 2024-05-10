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
    public partial class FormServicio : Form
    {
         //private SqlConnection conex;
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        public FormServicio()
        {
            InitializeComponent();
            
        }
      
        private void FormServicio_Load(object sender, EventArgs e)
        {
             buttonGuardar.Enabled = false;
            //buttonEliminar.Enabled = false;
            buttonEditar.Enabled = false;
            groupBoxServicio.Enabled = false;
            checkBox1.Checked = false;
            listar();
        }

        private void groupBoxServicio_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            
            buttonGuardar.Enabled = true;
            groupBoxServicio.Enabled=true;
            limpiar();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
           

            string sql, respuesta;
            


            try
            {
                servidor.AbrirConexin();
                sql = "Insert Into Servicio (nombre, cantidad_restante, disponibilidad) Values(@nom, @cant, @dis)"; //instruccion para insertar
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@cant", textBoxCantidad.Text);
                comando.Parameters.Add(param);
          
                param = new SqlParameter("@dis", checkBox1.Checked);
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
            listar();



        }
        private void limpiar()
        {
            textBoxNombre.Text = "";
            textBoxCantidad.Text = "";
            checkBox1.Checked = false;
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
           

        }

        private void listar()
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

        private void dataGridViewServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewServicio.Rows.Count - 1)
            {
                codigo = dataGridViewServicio.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewServicio.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCantidad.Text = dataGridViewServicio.Rows[e.RowIndex].Cells[2].Value.ToString();
                checkBox1.Checked = (bool)(dataGridViewServicio.Rows[e.RowIndex].Cells[3].Value);
          


                buttonEditar.Enabled = true;
               // buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = false;
                groupBoxServicio.Enabled = true;


            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string respuesta, sql;
            try
            {
                
                servidor.AbrirConexin();
                sql = "Update Servicio Set nombre = @nom, cantidad_restante = @cant, disponibilidad = @dis Where id_servicio = @Id";
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@cant", textBoxCantidad.Text);
                comando.Parameters.Add(param);
                param = new SqlParameter("@dis", checkBox1.Checked);
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
            limpiar();
            groupBoxServicio.Enabled = false;
            listar();
        }
    }
}


  