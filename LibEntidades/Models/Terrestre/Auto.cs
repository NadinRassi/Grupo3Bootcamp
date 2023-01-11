using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibEntidades.Models.BASE;

namespace LibEntidades.Models.BASE
{
    public class Auto : Terrestre
    {
        public Auto() { }
        public Auto(string nombre, string modelo, int anio, int cantRuedas, int pasajeros, bool conMotor, string propietario, string placa) : base(nombre, modelo, anio, cantRuedas, pasajeros, conMotor)
        {
            Propietario = propietario;
            Placa = placa;
        }
        public string Propietario { get; set; }
        public string Placa { get; set; }
    }
}
