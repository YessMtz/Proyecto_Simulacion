namespace CuadradoMedio
{
    partial class medioproducto
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
            this.val1 = new System.Windows.Forms.TextBox();
            this.val2 = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.tablita = new System.Windows.Forms.DataGridView();
            this.Tsemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semilla2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newsemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablita)).BeginInit();
            this.SuspendLayout();
            // 
            // val1
            // 
            this.val1.BackColor = System.Drawing.Color.Cornsilk;
            this.val1.Location = new System.Drawing.Point(129, 113);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(100, 20);
            this.val1.TabIndex = 0;
            // 
            // val2
            // 
            this.val2.BackColor = System.Drawing.Color.Cornsilk;
            this.val2.Location = new System.Drawing.Point(129, 150);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(100, 20);
            this.val2.TabIndex = 1;
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.Cornsilk;
            this.numero.Location = new System.Drawing.Point(129, 198);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "C:";
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.RosyBrown;
            this.calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcular.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.White;
            this.calcular.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calcular.Location = new System.Drawing.Point(36, 322);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(124, 27);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.RosyBrown;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limpiar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.White;
            this.limpiar.Location = new System.Drawing.Point(33, 355);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(127, 27);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // tablita
            // 
            this.tablita.AllowUserToAddRows = false;
            this.tablita.AllowUserToDeleteRows = false;
            this.tablita.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tablita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tsemilla,
            this.semilla2,
            this.producto,
            this.newsemilla,
            this.Resultado});
            this.tablita.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablita.Location = new System.Drawing.Point(306, 252);
            this.tablita.Name = "tablita";
            this.tablita.ReadOnly = true;
            this.tablita.Size = new System.Drawing.Size(444, 150);
            this.tablita.TabIndex = 11;
            // 
            // Tsemilla
            // 
            this.Tsemilla.HeaderText = "semilla";
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
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.RosyBrown;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(33, 396);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(127, 26);
            this.salir.TabIndex = 12;
            this.salir.Text = "Menú";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número \r\nde datos";
            // 
            // medioproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.tablita);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.val2);
            this.Controls.Add(this.val1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "medioproducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.productomedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox val1;
        private System.Windows.Forms.TextBox val2;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.DataGridView tablita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tsemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn semilla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label5;
    }
}