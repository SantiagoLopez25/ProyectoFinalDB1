using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDB1.Sys
{
    internal class Servicio
    {
        private string id;
        private string nombre;

        private int cantidad;
        private int nuevoValor;

        public Servicio(string id, string nombre, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.Cantidad = cantidad;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int NuevoValor{ get =>nuevoValor; }

        public void Calcular(int dis)
        {
            this.nuevoValor = dis - cantidad;
        }
    }
}
