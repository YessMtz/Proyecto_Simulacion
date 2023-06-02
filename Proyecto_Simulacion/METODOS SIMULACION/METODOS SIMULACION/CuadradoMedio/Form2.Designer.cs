namespace CuadradoMedio
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.cuadradomedio = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.medio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cuadradomedio
            // 
            this.cuadradomedio.BackColor = System.Drawing.Color.LightCoral;
            this.cuadradomedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuadradomedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cuadradomedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadradomedio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuadradomedio.Location = new System.Drawing.Point(55, 276);
            this.cuadradomedio.Name = "cuadradomedio";
            this.cuadradomedio.Size = new System.Drawing.Size(117, 56);
            this.cuadradomedio.TabIndex = 10;
            this.cuadradomedio.Text = "Chi \r\nCuadrada";
            this.cuadradomedio.UseVisualStyleBackColor = false;
            this.cuadradomedio.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightCoral;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.salir.Location = new System.Drawing.Point(254, 276);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(116, 56);
            this.salir.TabIndex = 13;
            this.salir.Text = "Salir";
            this.salir.UseMnemonic = false;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // medio
            // 
            this.medio.BackColor = System.Drawing.Color.LightCoral;
            this.medio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.medio.Location = new System.Drawing.Point(486, 276);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(148, 56);
            this.medio.TabIndex = 14;
            this.medio.Text = "Producto \r\nmedio";
            this.medio.UseVisualStyleBackColor = false;
            this.medio.Click += new System.EventHandler(this.medioproducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "PROGRAMA DE PRUEBAS ESTADISTICAS\r\nPARA NUMEROS PSEUDO ALEATORIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(67, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(231, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 74);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(501, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 96);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 414);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medio);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.cuadradomedio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cuadradomedio;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button medio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}