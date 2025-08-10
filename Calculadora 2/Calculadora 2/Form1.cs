using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            //NUMERO 0
            TBDISPLAT.Text += "0";
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            //NUMERO 1
            TBDISPLAT.Text += "1";
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            //NUMERO 2
            TBDISPLAT.Text += "2";
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            //NUMERO 3
            TBDISPLAT.Text += "3";
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            //NUMERO 4
            TBDISPLAT.Text += "4";
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            //NUMERO 5
            TBDISPLAT.Text += "5";
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            //NUMERO 6
            TBDISPLAT.Text += "6";
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            //NUMERO 7
            TBDISPLAT.Text += "7";
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            //NUMERO 8
            TBDISPLAT.Text += "8";
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            //NUMERO 9
            TBDISPLAT.Text += "9";
        }

        private void BTNPUNTO_Click(object sender, EventArgs e)
        {
            //NUMERO PUNTO
            if (!TBDISPLAT.Text.Contains("."))
            {
                TBDISPLAT.Text += ".";
            }
        }

        private void BTNIGUAL_Click(object sender, EventArgs e)
        {
            // BOTON IGUAL
            try
            {
                // Evaluar la expresión en TBDISPLAT
                var result = new DataTable().Compute(TBDISPLAT.Text, null);
                TBDISPLAT.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la expresión: " + ex.Message);
                TBDISPLAT.Text = "";
            }

        }

        private void BTNSUMA_Click(object sender, EventArgs e)
        {
            // BOTON SUMA
            TBDISPLAT.Text += "+";





        }

        private void BTNRESTA_Click(object sender, EventArgs e)
        {
            // BOTON RESTA
            TBDISPLAT.Text += "-";
        }

        private void BTNX_Click(object sender, EventArgs e)
        {
            // BOTON MULTIPLICACION
            TBDISPLAT.Text += "*";
        }

        private void BTNDIV_Click(object sender, EventArgs e)
        {
            // BOTON DIVISION
            TBDISPLAT.Text += "/";
        }

        private void BTNDELEL_Click(object sender, EventArgs e)
        {
            // BOTON BORRAR
            if (TBDISPLAT.Text.Length > 0)
            {
                TBDISPLAT.Text = TBDISPLAT.Text.Substring(0, TBDISPLAT.Text.Length - 1);
            }


        }
    }
}
