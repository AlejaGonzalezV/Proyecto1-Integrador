﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proyecto1
{
    public partial class VentanaPrincipal : Form
    {
        Universidad icesi;
        public VentanaPrincipal()
        {
            InitializeComponent();
            icesi = new Universidad("ICESI");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = NombreTx.Text;
            string apellido = ApellidoTx.Text;
            string cedula = CedulaTx.Text;
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");

            icesi.Guardar(nombre, apellido, cedula, fecha_actual);

            NombreTx.Clear();
            ApellidoTx.Clear();
            CedulaTx.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            VentanaLista lista = new VentanaLista();
            lista.Show();


        }

        private void TituloTx_Click(object sender, EventArgs e)
        {

        }

        private void ApellidoTx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NombreTx_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
