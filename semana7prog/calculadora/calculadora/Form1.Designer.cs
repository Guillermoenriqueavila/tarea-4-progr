
namespace calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonSuma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texbox2 = new System.Windows.Forms.TextBox();
            this.botonResta = new System.Windows.Forms.Button();
            this.botonDiv = new System.Windows.Forms.Button();
            this.botonMultiplicacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonSuma
            // 
            this.botonSuma.Location = new System.Drawing.Point(222, 34);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(75, 23);
            this.botonSuma.TabIndex = 0;
            this.botonSuma.Text = "Suma";
            this.botonSuma.UseVisualStyleBackColor = true;
            this.botonSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2: ";
            // 
            // texbox2
            // 
            this.texbox2.Location = new System.Drawing.Point(96, 68);
            this.texbox2.Name = "texbox2";
            this.texbox2.Size = new System.Drawing.Size(100, 20);
            this.texbox2.TabIndex = 4;
            // 
            // botonResta
            // 
            this.botonResta.Location = new System.Drawing.Point(222, 71);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(75, 23);
            this.botonResta.TabIndex = 5;
            this.botonResta.Text = "Resta";
            this.botonResta.UseVisualStyleBackColor = true;
            this.botonResta.Click += new System.EventHandler(this.botonResta_Click);
            // 
            // botonDiv
            // 
            this.botonDiv.Location = new System.Drawing.Point(314, 34);
            this.botonDiv.Name = "botonDiv";
            this.botonDiv.Size = new System.Drawing.Size(93, 23);
            this.botonDiv.TabIndex = 6;
            this.botonDiv.Text = "Dividir";
            this.botonDiv.UseVisualStyleBackColor = true;
            this.botonDiv.Click += new System.EventHandler(this.botonDiv_Click);
            // 
            // botonMultiplicacion
            // 
            this.botonMultiplicacion.Location = new System.Drawing.Point(314, 71);
            this.botonMultiplicacion.Name = "botonMultiplicacion";
            this.botonMultiplicacion.Size = new System.Drawing.Size(93, 23);
            this.botonMultiplicacion.TabIndex = 7;
            this.botonMultiplicacion.Text = "Multiplicación";
            this.botonMultiplicacion.UseVisualStyleBackColor = true;
            this.botonMultiplicacion.Click += new System.EventHandler(this.botonMultiplicacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(30, 117);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(35, 13);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "label4";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(267, 107);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 10;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 159);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonMultiplicacion);
            this.Controls.Add(this.botonDiv);
            this.Controls.Add(this.botonResta);
            this.Controls.Add(this.texbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonSuma);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSuma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texbox2;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button botonDiv;
        private System.Windows.Forms.Button botonMultiplicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button botonBorrar;
    }
}

