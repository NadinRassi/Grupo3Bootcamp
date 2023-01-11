using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEntidades.Models.BASE
{
    public class Moto : Terrestre
    {
        public Moto() { }

        public Moto(string nombre, string modelo, int anio, int cantRuedas, int pasajeros, bool conMotor, string marca, int cilindrada) : base(nombre, modelo, anio, cantRuedas, pasajeros, conMotor)
        {
            Marca = marca;
            Cilindrada = cilindrada;
        }

        public string Marca { get; set; }

        public int Cilindrada { get; set; }



    }

}
