namespace CuadradoMedio
{
    partial class Contantemul
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tablita = new System.Windows.Forms.DataGridView();
            this.Tsemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semilla2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newsemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.semilla1 = new System.Windows.Forms.TextBox();
            this.semiila2 = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(99, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "c:";
            // 
            // tablita
            // 
            this.tablita.AllowUserToAddRows = false;
            this.tablita.AllowUserToDeleteRows = false;
            this.tablita.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tsemilla,
            this.semilla2,
            this.producto,
            this.newsemilla,
            this.Resultado});
            this.tablita.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablita.Location = new System.Drawing.Point(320, 327);
            this.tablita.Name = "tablita";
            this.tablita.ReadOnly = true;
            this.tablita.Size = new System.Drawing.Size(444, 150);
            this.tablita.TabIndex = 12;
            // 
            // Tsemilla
            // 
            this.Tsemilla.HeaderText = "semilla C";
            this.Tsemilla.Name = "Tsemilla";
            this.Tsemilla.ReadOnly = true;
            // 
            // semilla2
            // 
            this.semilla2.HeaderText = "semilla 2";
            this.semilla2.Name = "semilla2";
            this.semilla2.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // newsemilla
            // 
            this.newsemilla.HeaderText = "nueva semilla";
            this.newsemilla.Name = "newsemilla";
            this.newsemilla.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(467, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(467, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.RosyBrown;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(62, 450);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(113, 32);
            this.salir.TabIndex = 16;
            this.salir.Text = "pantalla menú";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.RosyBrown;
            this.calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.White;
            this.calcular.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calcular.Location = new System.Drawing.Point(62, 374);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(113, 28);
            this.calcular.TabIndex = 17;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.RosyBrown;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.White;
            this.limpiar.Location = new System.Drawing.Point(62, 408);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(113, 36);
            this.limpiar.TabIndex = 18;
            this.limpiar.Text = "limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // semilla1
            // 
            this.semilla1.BackColor = System.Drawing.Color.Cornsilk;
            this.semilla1.Location = new System.Drawing.Point(139, 191);
            this.semilla1.Name = "semilla1";
            this.semilla1.Size = new System.Drawing.Size(100, 20);
            this.semilla1.TabIndex = 19;
            // 
            // semiila2
            // 
            this.semiila2.BackColor = System.Drawing.Color.Cornsilk;
            this.semiila2.Location = new System.Drawing.Point(139, 155);
            this.semiila2.Name = "semiila2";
            this.semiila2.Size = new System.Drawing.Size(100, 20);
            this.semiila2.TabIndex = 20;
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.Cornsilk;
            this.numero.Location = new System.Drawing.Point(139, 226);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 40);
            this.label3.TabIndex = 22;
            this.label3.Text = "Multiplicador\r\nConstante\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(160, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "PRUEBAS ESTADISTICAS";
            // 
            // Contantemul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.semiila2);
            this.Controls.Add(this.semilla1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tablita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contantemul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.tablita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablita;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tsemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn semilla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox semilla1;
        private System.Windows.Forms.TextBox semiila2;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}