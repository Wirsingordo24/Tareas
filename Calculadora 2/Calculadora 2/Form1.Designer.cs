namespace Calculadora_2
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
            this.TBDISPLAT = new System.Windows.Forms.TextBox();
            this.BTNSUMA = new System.Windows.Forms.Button();
            this.BTNRESTA = new System.Windows.Forms.Button();
            this.BTNX = new System.Windows.Forms.Button();
            this.BTNDIV = new System.Windows.Forms.Button();
            this.BTN7 = new System.Windows.Forms.Button();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTN9 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTNPUNTO = new System.Windows.Forms.Button();
            this.BTN0 = new System.Windows.Forms.Button();
            this.BTNIGUAL = new System.Windows.Forms.Button();
            this.BTNDELEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBDISPLAT
            // 
            this.TBDISPLAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDISPLAT.Location = new System.Drawing.Point(15, 21);
            this.TBDISPLAT.Multiline = true;
            this.TBDISPLAT.Name = "TBDISPLAT";
            this.TBDISPLAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TBDISPLAT.Size = new System.Drawing.Size(307, 40);
            this.TBDISPLAT.TabIndex = 0;
            this.TBDISPLAT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTNSUMA
            // 
            this.BTNSUMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUMA.Location = new System.Drawing.Point(15, 67);
            this.BTNSUMA.Name = "BTNSUMA";
            this.BTNSUMA.Size = new System.Drawing.Size(99, 49);
            this.BTNSUMA.TabIndex = 1;
            this.BTNSUMA.Text = "+";
            this.BTNSUMA.UseVisualStyleBackColor = true;
            this.BTNSUMA.Click += new System.EventHandler(this.BTNSUMA_Click);
            // 
            // BTNRESTA
            // 
            this.BTNRESTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRESTA.Location = new System.Drawing.Point(120, 67);
            this.BTNRESTA.Name = "BTNRESTA";
            this.BTNRESTA.Size = new System.Drawing.Size(85, 49);
            this.BTNRESTA.TabIndex = 2;
            this.BTNRESTA.Text = "-";
            this.BTNRESTA.UseVisualStyleBackColor = true;
            this.BTNRESTA.Click += new System.EventHandler(this.BTNRESTA_Click);
            // 
            // BTNX
            // 
            this.BTNX.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNX.Location = new System.Drawing.Point(211, 67);
            this.BTNX.Name = "BTNX";
            this.BTNX.Size = new System.Drawing.Size(87, 49);
            this.BTNX.TabIndex = 3;
            this.BTNX.Text = "X";
            this.BTNX.UseVisualStyleBackColor = true;
            this.BTNX.Click += new System.EventHandler(this.BTNX_Click);
            // 
            // BTNDIV
            // 
            this.BTNDIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDIV.Location = new System.Drawing.Point(304, 67);
            this.BTNDIV.Name = "BTNDIV";
            this.BTNDIV.Size = new System.Drawing.Size(85, 49);
            this.BTNDIV.TabIndex = 4;
            this.BTNDIV.Text = "/";
            this.BTNDIV.UseVisualStyleBackColor = true;
            this.BTNDIV.Click += new System.EventHandler(this.BTNDIV_Click);
            // 
            // BTN7
            // 
            this.BTN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN7.Location = new System.Drawing.Point(12, 122);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(122, 67);
            this.BTN7.TabIndex = 5;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = true;
            this.BTN7.Click += new System.EventHandler(this.BTN7_Click);
            // 
            // BTN8
            // 
            this.BTN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN8.Location = new System.Drawing.Point(140, 122);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(122, 67);
            this.BTN8.TabIndex = 6;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = true;
            this.BTN8.Click += new System.EventHandler(this.BTN8_Click);
            // 
            // BTN9
            // 
            this.BTN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN9.Location = new System.Drawing.Point(268, 122);
            this.BTN9.Name = "BTN9";
            this.BTN9.Size = new System.Drawing.Size(122, 67);
            this.BTN9.TabIndex = 7;
            this.BTN9.Text = "9";
            this.BTN9.UseVisualStyleBackColor = true;
            this.BTN9.Click += new System.EventHandler(this.BTN9_Click);
            // 
            // BTN4
            // 
            this.BTN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN4.Location = new System.Drawing.Point(12, 195);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(122, 67);
            this.BTN4.TabIndex = 8;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = true;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // BTN5
            // 
            this.BTN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN5.Location = new System.Drawing.Point(141, 192);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(122, 67);
            this.BTN5.TabIndex = 9;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = true;
            this.BTN5.Click += new System.EventHandler(this.BTN5_Click);
            // 
            // BTN6
            // 
            this.BTN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN6.Location = new System.Drawing.Point(268, 192);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(122, 67);
            this.BTN6.TabIndex = 10;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = true;
            this.BTN6.Click += new System.EventHandler(this.BTN6_Click);
            // 
            // BTN1
            // 
            this.BTN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN1.Location = new System.Drawing.Point(15, 268);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(122, 67);
            this.BTN1.TabIndex = 11;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // BTN2
            // 
            this.BTN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BTN2.Location = new System.Drawing.Point(143, 265);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(122, 67);
            this.BTN2.TabIndex = 12;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN3
            // 
            this.BTN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3.Location = new System.Drawing.Point(268, 268);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(122, 67);
            this.BTN3.TabIndex = 13;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = true;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // BTNPUNTO
            // 
            this.BTNPUNTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPUNTO.Location = new System.Drawing.Point(15, 341);
            this.BTNPUNTO.Name = "BTNPUNTO";
            this.BTNPUNTO.Size = new System.Drawing.Size(122, 67);
            this.BTNPUNTO.TabIndex = 14;
            this.BTNPUNTO.Text = ".";
            this.BTNPUNTO.UseVisualStyleBackColor = true;
            this.BTNPUNTO.Click += new System.EventHandler(this.BTNPUNTO_Click);
            // 
            // BTN0
            // 
            this.BTN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN0.Location = new System.Drawing.Point(141, 338);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(122, 67);
            this.BTN0.TabIndex = 15;
            this.BTN0.Text = "0";
            this.BTN0.UseVisualStyleBackColor = true;
            this.BTN0.Click += new System.EventHandler(this.BTN0_Click);
            // 
            // BTNIGUAL
            // 
            this.BTNIGUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIGUAL.Location = new System.Drawing.Point(268, 338);
            this.BTNIGUAL.Name = "BTNIGUAL";
            this.BTNIGUAL.Size = new System.Drawing.Size(122, 67);
            this.BTNIGUAL.TabIndex = 16;
            this.BTNIGUAL.Text = "=";
            this.BTNIGUAL.UseVisualStyleBackColor = true;
            this.BTNIGUAL.Click += new System.EventHandler(this.BTNIGUAL_Click);
            // 
            // BTNDELEL
            // 
            this.BTNDELEL.Location = new System.Drawing.Point(328, 21);
            this.BTNDELEL.Name = "BTNDELEL";
            this.BTNDELEL.Size = new System.Drawing.Size(61, 45);
            this.BTNDELEL.TabIndex = 17;
            this.BTNDELEL.Text = "C";
            this.BTNDELEL.UseVisualStyleBackColor = true;
            this.BTNDELEL.Click += new System.EventHandler(this.BTNDELEL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.BTNDELEL);
            this.Controls.Add(this.BTNIGUAL);
            this.Controls.Add(this.BTN0);
            this.Controls.Add(this.BTNPUNTO);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.BTN6);
            this.Controls.Add(this.BTN5);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.BTN9);
            this.Controls.Add(this.BTN8);
            this.Controls.Add(this.BTN7);
            this.Controls.Add(this.BTNDIV);
            this.Controls.Add(this.BTNX);
            this.Controls.Add(this.BTNRESTA);
            this.Controls.Add(this.BTNSUMA);
            this.Controls.Add(this.TBDISPLAT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBDISPLAT;
        private System.Windows.Forms.Button BTNSUMA;
        private System.Windows.Forms.Button BTNRESTA;
        private System.Windows.Forms.Button BTNX;
        private System.Windows.Forms.Button BTNDIV;
        private System.Windows.Forms.Button BTN7;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTN9;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTNPUNTO;
        private System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.Button BTNIGUAL;
        private System.Windows.Forms.Button BTNDELEL;
    }
}

