using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades.Models.BASE
{
    public abstract class Transporte
    {
        public Transporte() { }
        public Transporte(string nombre, string modelo, int anio)
        {
            Nombre = nombre;

            Modelo = modelo;

            Anio = anio;
        }

        public string Nombre { get; set; }
        public string Modelo { get; set; }

        public int Anio { get; set; }
    }
}
