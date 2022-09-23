
namespace Calculator
{
    partial class Form1
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
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkSuma = new System.Windows.Forms.CheckBox();
            this.checkBoxDiv = new System.Windows.Forms.CheckBox();
            this.checkBoxResta = new System.Windows.Forms.CheckBox();
            this.checkBoxMulti = new System.Windows.Forms.CheckBox();
            this.botonOperar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Location = new System.Drawing.Point(75, 29);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(59, 13);
            this.lbNumero1.TabIndex = 0;
            this.lbNumero1.Text = "Número 1: ";
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Location = new System.Drawing.Point(75, 62);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(59, 13);
            this.lbNumero2.TabIndex = 1;
            this.lbNumero2.Text = "Número 2: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // checkSuma
            // 
            this.checkSuma.AutoSize = true;
            this.checkSuma.Location = new System.Drawing.Point(255, 29);
            this.checkSuma.Name = "checkSuma";
            this.checkSuma.Size = new System.Drawing.Size(53, 17);
            this.checkSuma.TabIndex = 4;
            this.checkSuma.Text = "Suma";
            this.checkSuma.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiv
            // 
            this.checkBoxDiv.AutoSize = true;
            this.checkBoxDiv.Location = new System.Drawing.Point(255, 65);
            this.checkBoxDiv.Name = "checkBoxDiv";
            this.checkBoxDiv.Size = new System.Drawing.Size(63, 17);
            this.checkBoxDiv.TabIndex = 5;
            this.checkBoxDiv.Text = "División";
            this.checkBoxDiv.UseVisualStyleBackColor = true;
            // 
            // checkBoxResta
            // 
            this.checkBoxResta.AutoSize = true;
            this.checkBoxResta.Location = new System.Drawing.Point(362, 29);
            this.checkBoxResta.Name = "checkBoxResta";
            this.checkBoxResta.Size = new System.Drawing.Size(54, 17);
            this.checkBoxResta.TabIndex = 6;
            this.checkBoxResta.Text = "Resta";
            this.checkBoxResta.UseVisualStyleBackColor = true;
            // 
            // checkBoxMulti
            // 
            this.checkBoxMulti.AutoSize = true;
            this.checkBoxMulti.Location = new System.Drawing.Point(362, 65);
            this.checkBoxMulti.Name = "checkBoxMulti";
            this.checkBoxMulti.Size = new System.Drawing.Size(90, 17);
            this.checkBoxMulti.TabIndex = 7;
            this.checkBoxMulti.Text = "Multiplicación";
            this.checkBoxMulti.UseVisualStyleBackColor = true;
            // 
            // botonOperar
            // 
            this.botonOperar.Location = new System.Drawing.Point(175, 117);
            this.botonOperar.Name = "botonOperar";
            this.botonOperar.Size = new System.Drawing.Size(75, 23);
            this.botonOperar.TabIndex = 8;
            this.botonOperar.Text = "Operar";
            this.botonOperar.UseVisualStyleBackColor = true;
            this.botonOperar.Click += new System.EventHandler(this.botonOperar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(196, 163);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(35, 13);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "label1";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(296, 117);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 10;
            this.botonLimpiar.Text = "Borrar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 200);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.botonOperar);
            this.Controls.Add(this.checkBoxMulti);
            this.Controls.Add(this.checkBoxResta);
            this.Controls.Add(this.checkBoxDiv);
            this.Controls.Add(this.checkSuma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkSuma;
        private System.Windows.Forms.CheckBox checkBoxDiv;
        private System.Windows.Forms.CheckBox checkBoxResta;
        private System.Windows.Forms.CheckBox checkBoxMulti;
        private System.Windows.Forms.Button botonOperar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button botonLimpiar;
    }
}

