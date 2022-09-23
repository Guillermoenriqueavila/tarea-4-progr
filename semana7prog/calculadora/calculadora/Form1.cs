using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        double num1, num2, resultado;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox1.Text);
            num2 = Double.Parse(texbox2.Text);
            resultado = num1 / num2;
            labelResultado.Text = "El resultado de la division es: " + resultado.ToString();

            botonSuma.Enabled = false;
            botonResta.Enabled = false;
            botonMultiplicacion.Enabled = false;
            botonDiv.Enabled = false;
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox1.Text);
            num2 = Double.Parse(texbox2.Text);
            resultado = num1 - num2;
            labelResultado.Text = "El resultado de la resta es: " + resultado.ToString();

            botonSuma.Enabled = false;
            botonResta.Enabled = false;
            botonMultiplicacion.Enabled = false;
            botonDiv.Enabled = false;

        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox1.Text);
            num2 = Double.Parse(texbox2.Text);
            resultado = num1 * num2;
            labelResultado.Text = "El resultado de la multiplicacion es: " + resultado.ToString();

            botonSuma.Enabled = false;
            botonResta.Enabled = false;
            botonMultiplicacion.Enabled = false;
            botonDiv.Enabled = false;
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            texbox2.Clear();
            labelResultado.Text = "";
            botonSuma.Enabled = true;
            botonResta.Enabled = true;
            botonMultiplicacion.Enabled = true;
            botonDiv.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            texbox2.Text = "0";
            textBox1.Text = "0";
            this.Text = "Calculadora";
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox1.Text);
            num2 = Double.Parse(texbox2.Text);
            resultado = num1 + num2;
            labelResultado.Text = "El resultado de la suma es: " + resultado.ToString();

            botonSuma.Enabled = false;
            botonResta.Enabled = false;
            botonMultiplicacion.Enabled = false;
            botonDiv.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
