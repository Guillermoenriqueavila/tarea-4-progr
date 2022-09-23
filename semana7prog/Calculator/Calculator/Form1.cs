using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelResultado.Text = "";

            checkSuma.Checked = false;
            checkBoxResta.Checked = false;
            checkBoxMulti.Checked = false;
            checkBoxDiv.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
            textBox2.Text = "0";
            textBox1.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void botonOperar_Click(object sender, EventArgs e)
        {
            if (checkSuma.Checked == true)
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                resultado = num1 + num2;
                labelResultado.Text = "El resultado de la suma es: " + resultado.ToString();
            }else if (checkBoxResta.Checked == true)
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                resultado = num1 - num2;
                labelResultado.Text = "El resultado de la resta es: " + resultado.ToString();
            }else if (checkBoxDiv.Checked == true)
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                resultado = num1 / num2;
                labelResultado.Text = "El resultado de la divicion es: " + resultado.ToString();
            }
            else if (checkBoxMulti.Checked == true)
            {
                num1 = Double.Parse(textBox1.Text);
                num2 = Double.Parse(textBox2.Text);
                resultado = num1 * num2;
                labelResultado.Text = "El resultado de la multiplicacion es: " + resultado.ToString();
            }
        }
    }
}
