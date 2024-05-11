using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDB1.Sys
{
    internal class Usuario
    {
        private string nombre;
        private int privilegios;
    
        public Usuario() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Privilegios { get => privilegios; set => privilegios = value; }
    }
}
