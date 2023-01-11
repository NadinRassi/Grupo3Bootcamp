using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades.Models.BASE
{
    public abstract class Terrestre : Transporte
    {
        public Terrestre() { }

        public Terrestre(string nombre, string modelo, int anio, int cantRuedas, int pasajeros, bool conMotor):base(nombre, modelo, anio)
        {
            CantRuedas = cantRuedas;
            Pasajeros = pasajeros;
            ConMotor = conMotor;
        }

        public int CantRuedas { get; set; }

        public int Pasajeros { get; set; }

        public bool ConMotor { get; set; }
    }
}
