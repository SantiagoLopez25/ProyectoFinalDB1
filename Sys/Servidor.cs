using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ProyectoFinalDB1.Sys
{
    internal class Servidor
    {

        private SqlConnection _SQLServer;

        public Servidor() : this(new Config()) { }
        public Servidor(Config conf)
        {

            //this._SQLServer = new SqlConnection("Server=" + conf.Server + "; Database=" + conf.Database + "; User Id=" + conf.User + "; Password=" + conf.Pass + "; Encrypt=False");
            this._SQLServer = new SqlConnection("Server=" + conf.Server + "; Database=" + conf.Database + "; Trusted_Connection=True;  Encrypt =False") ;
        }

        public SqlConnection SQLServer { get => this._SQLServer;  }

        public void AbrirConexin()
        {
            if (this._SQLServer != null)
            {
                this._SQLServer.Open();
            }
        }

        public void CerrarConexion()
        {
            if (this._SQLServer != null)
            {
                this._SQLServer.Close();
            }
        }
    }
}
