﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibEntidades.Models.BASE;

namespace LibEntidades.Models.BASE
{
    public class Helicoptero : Aereo
    {
        public Helicoptero() { }

        public Helicoptero(string nombre, string modelo, int anio, int capPasajeros, string modoVuelo, string funcionalidad, string tipo, string tamanio) : base(nombre, modelo, anio, capPasajeros, modoVuelo, funcionalidad)
        {

            Tipo = tipo;

            Tamanio = tamanio;

        }

        public string Tipo { get; set; }

        public string Tamanio { get; set; }
    }
}
