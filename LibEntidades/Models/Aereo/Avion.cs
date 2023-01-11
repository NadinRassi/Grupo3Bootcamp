using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibEntidades.Models.BASE;

namespace LibEntidades.Models.BASE
{
    public class Avion : Aereo 
    {
        public Avion() { }

        public Avion(string nombre, string modelo, int anio, int capPasajeros, string modoVuelo, string funcionalidad, string propietario, string aerolinea):base(nombre, modelo, anio, capPasajeros, modoVuelo, funcionalidad)
        {

            Propietario = propietario;

            Aerolinea = aerolinea;

        }

        public string Propietario { get; set; }

        public string Aerolinea { get; set; }
    }
}
