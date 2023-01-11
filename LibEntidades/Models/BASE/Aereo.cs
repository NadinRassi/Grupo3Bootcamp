using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades.Models.BASE
{
    public abstract class Aereo : Transporte
    {
        public Aereo() {}
        public Aereo(string nombre, string modelo, int anio, int capPasajeros, string modoVuelo, string funcionalidad):base(nombre, modelo, anio)
        {
            CapPasajeros = capPasajeros;
            ModoVuelo = modoVuelo;
            Funcionalidad = funcionalidad;
        }
        public int CapPasajeros { get; set; }

        public string ModoVuelo { get; set; }

        public string Funcionalidad { get; set; }
    }
}
