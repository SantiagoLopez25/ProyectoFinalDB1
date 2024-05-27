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
    public partial class FormCantidadSalones : Form
    {
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlParameter param;
        private DataTable datos;
        private string cadena;
        private string codigo;
        Servidor servidor = new Servidor();
        public FormCantidadSalones()
        {
            InitializeComponent();
        }

        private void FormCantidadSalones_Load(object sender, EventArgs e)
        {
            Llenar_tabla_categorias();
        }

        private void Llenar_tabla_categorias()
        {
            string respuesta, sql;
            try
            {
                servidor.AbrirConexin();
                sql = "select Tipo_salon.nombre, count(Salon.nombre) as 'Cantidad' from Tipo_salon, salon\r\nwhere Tipo_salon.id_tipo = Salon.id_tipo\r\ngroup by Tipo_salon.nombre"; //instruccion para listar el contenido de la tabla capacitador
                comando = new SqlCommand(sql, servidor.SQLServer); //configura
                adaptador = new SqlDataAdapter(comando); //Ejecuta, abstracta
                datos = new DataTable();
                adaptador.Fill(datos);
                dataGridViewCategorias.DataSource = datos;
                dataGridViewCategorias.Refresh();
                dataGridViewCategorias.AutoResizeColumns();
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
            this.Close();
        }
    }
}
