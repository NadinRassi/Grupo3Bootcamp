using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades.Models.BASE
{
    public class Zeppelin : Aereo
    {
        public Zeppelin() { }

        public Zeppelin(string nombre, string modelo, int anio, int capPasajeros, string modoVuelo, string funcionalidad, string tipoAire, string tamanio) : base(nombre, modelo, anio, capPasajeros, modoVuelo, funcionalidad)
        {

            TipoAire = tipoAire;

            Tamanio = tamanio;

        }

        public string TipoAire { get; set; }

        public string Tamanio { get; set; }

    }
}
