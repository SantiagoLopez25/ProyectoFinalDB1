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
using ProyectoFinalDB1.Sys;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinalDB1
{
    public partial class FormTipoSalon : Form
    {

        //private SqlConnection conex;
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        public FormTipoSalon()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
            
            groupBoxTipo.Enabled = true;
            limpiar();
        }

        private void limpiar()
        {
            textBoxNombre.Text = "";
        }

        private void FormTipoSalon_Load(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = false;
            //buttonEliminar.Enabled = false;
            buttonEditar.Enabled = false;
            groupBoxTipo.Enabled = false;
            listar();
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string sql, respuesta;



            try
            {
                servidor.AbrirConexin();
                sql = "Insert Into Tipo_salon (nombre) Values(@nom)"; //instruccion para insertar
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
                comando.Parameters.Add(param);
              
                comando.ExecuteNonQuery();
                respuesta = "Se ha creado un nuevo registro en Tipo de salón";
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
            groupBoxTipo.Enabled=false;
            listar();
        }

        private void listar()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "Select * From Tipo_salon"; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewTipoSalon.DataSource = datos;
                dataGridViewTipoSalon.Refresh();
                dataGridViewTipoSalon.AutoResizeColumns();
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
                sql = "Update Tipo_salon Set nombre = @nom Where id_tipo = @Id";
                comando = new SqlCommand(sql, servidor.SQLServer);
                param = new SqlParameter("@nom", textBoxNombre.Text);
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
            groupBoxTipo.Enabled = false;
            listar();
        }

        private void dataGridViewTipoSalon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTipoSalon.Rows.Count - 1)
            {
                codigo = dataGridViewTipoSalon.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewTipoSalon.Rows[e.RowIndex].Cells[1].Value.ToString();
               



                buttonEditar.Enabled = true;
                // buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = false;
                groupBoxTipo.Enabled = true;


            }
        }
    }
    
}
