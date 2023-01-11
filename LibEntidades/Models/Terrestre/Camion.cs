using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades.Models.BASE
{
    public class Camion : Terrestre
    {
        public Camion() { }
        public Camion(string nombre, string modelo, int anio, int cantRuedas, int pasajeros, bool conMotor, string propietario, string placa, string tipoDeCarga)
            : base(nombre, modelo, anio, cantRuedas, pasajeros, conMotor)
        {
            Propietario = propietario;
            Placa = placa;
            TipoDeCarga = tipoDeCarga;
        }
        public string Propietario { get; set; }
        public string Placa { get; set; }
        public string TipoDeCarga { get; set; }
    }
}

