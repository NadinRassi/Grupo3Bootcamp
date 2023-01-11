using LibEntidades.Models.BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrupo3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearTransporte_Click(object sender, EventArgs e)
        {
            Avion avion_comercial = new Avion("Avión comercial", "Boeing 787", 2019, 140, "Turbina", "Transporte pasajeros", "Julian Cook", "Flybondi");

            MessageBox.Show("Nombre: " + avion_comercial.Nombre + "\nModelo: " + avion_comercial.Modelo + "\nAño: " + avion_comercial.Anio + "\nCapacidad de pasajeros: " + avion_comercial.CapPasajeros + "\nModo de vuelo: " + avion_comercial.ModoVuelo + "\nFunción: " + avion_comercial.Funcionalidad + "\nPropietario: " + avion_comercial.Propietario + "\nAerolínea: " + avion_comercial.Aerolinea);
        }
    }
}
