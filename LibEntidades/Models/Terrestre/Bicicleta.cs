using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades.Models.BASE
{
    public class Bicicleta : Terrestre
    {
        public Bicicleta() { }

        public Bicicleta(string nombre, string modelo, int anio, int cantRuedas, int pasajeros, bool conMotor, string marca, string tipo) : base(nombre, modelo, anio, cantRuedas, pasajeros, conMotor)
        {
            Marca = marca;
            Tipo = tipo;
        }

        public string Marca { get; set; }

        public string Tipo { get; set; }



    }

}
