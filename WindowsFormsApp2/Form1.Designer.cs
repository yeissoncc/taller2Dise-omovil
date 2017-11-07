namespace WindowsFormsApp2
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.borrar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.rais = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(68, 48);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(494, 20);
            this.pantalla.TabIndex = 0;
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(68, 111);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(109, 38);
            this.borrar.TabIndex = 1;
            this.borrar.Text = "CE";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(68, 155);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(109, 38);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(68, 199);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(109, 38);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(68, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(109, 38);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(68, 287);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(239, 38);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button5_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(198, 111);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(109, 38);
            this.dividir.TabIndex = 1;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(198, 155);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(109, 38);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(198, 199);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(109, 38);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(198, 243);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(109, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(328, 111);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(109, 38);
            this.multiplicar.TabIndex = 1;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(328, 155);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(109, 38);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(328, 199);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(109, 38);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(328, 243);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 38);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(328, 287);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(109, 38);
            this.button15.TabIndex = 1;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(453, 111);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(109, 38);
            this.resta.TabIndex = 1;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(453, 155);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(109, 38);
            this.suma.TabIndex = 1;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // rais
            // 
            this.rais.Location = new System.Drawing.Point(453, 199);
            this.rais.Name = "rais";
            this.rais.Size = new System.Drawing.Size(109, 38);
            this.rais.TabIndex = 1;
            this.rais.Text = "RAIZ";
            this.rais.UseVisualStyleBackColor = true;
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(453, 243);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(109, 82);
            this.igual.TabIndex = 1;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 377);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rais);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button rais;
        private System.Windows.Forms.Button igual;
    }
}

