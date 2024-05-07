using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDB1.Sys
{
    internal class Config
    {

        private string server;
        private string database;

        private string user;
        private string pass;

        public Config()
        {
             this.server = "localhost";
            //this.server = "HP_SANTIAGO";
            //this.database = "DBProyecto1";
            this.database = "ProyectoDB1";

            this.user = "sa";
            this.pass = "database";
        }

        public void cargar()
        {
            
        }

        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
