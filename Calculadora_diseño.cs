using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora_diseño : Form
    {
        float Dato1, Dato2, resultado;
        bool suma, resta, multiplicacion, division, potencia;

        public Calculadora_diseño()
        {
            InitializeComponent();
            suma = false;
            resta = false;
            multiplicacion = false;
            division = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "4";
        }

        private void btn_NumUno_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "1";
            //signo igal cambia al valro, mientras qe el mas concatena
            //Dato1 = float.Parse(txt_caja.Text); 
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "2";
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "3";
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "5";
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "6";
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "7";
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "8";
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "9";
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            txt_caja.Text += "0";
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_caja.Text = "";
            //se ponen comillas acias para que borre todo
            Dato1 = 0;
            Dato2 = 0;
            resultado = 0;
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            Dato1 = float.Parse(txt_caja.Text);
            txt_caja.Text = "";
            suma = true;
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            Dato1 = float.Parse(txt_caja.Text);
            txt_caja.Text = "";
            resta = true;
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            Dato1 = float.Parse(txt_caja.Text);
            txt_caja.Text = "";
            multiplicacion = true;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            Dato1 = float.Parse(txt_caja.Text);
            txt_caja.Text = "";
            division = true;

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            // if (suma || resta||multiplicacion||division)
            //{
            //    txt_caja.Text = "0";
            //  Dato2 = float.Parse(txt_caja.Text); 
            //}
            //else
            //{
            //  Dato2 = float.Parse(txt_caja.Text);
            //resultado = Dato1 + Dato2;
            //txt_caja.Text = resultado.ToString(); 
            //}
            Dato2 = float.Parse(txt_caja.Text);
            if (suma)
            {
                resultado = suma ? Dato1 + Dato2 : resultado = 0;
                suma = false;
            }
            else if (resta)
            {
                resultado = resta ? Dato1 - Dato2 : resultado = 0;
                resta = false;
            }
            else if (multiplicacion)
            {
                resultado = multiplicacion ? Dato1 * Dato2 : resultado = 0;
                multiplicacion = false;
            }
            else if (division)
            {
                resultado = division ? Dato1 / Dato2 : resultado = 0;
                division = false;
            }
            else if (potencia)
            {
                resultado = potencia ? ((int)Dato1) * ((int)Dato2) : resultado = 0;
            }
            txt_caja.Text = resultado.ToString();
        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            Dato1 = float.Parse(txt_caja.Text);
            txt_caja.Text = "";
            potencia = true; 
        }
    }
}
