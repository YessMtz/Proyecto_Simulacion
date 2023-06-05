namespace CuadradoMedio
{
    partial class cuadradomedio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.varA = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.Tablas = new System.Windows.Forms.DataGridView();
            this.Tsemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newsemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limpiar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.botonchi = new System.Windows.Forms.Button();
            this.tablachi = new System.Windows.Forms.Button();
            this.confianza = new System.Windows.Forms.Label();
            this.busquedaconfianza = new System.Windows.Forms.TextBox();
            this.letrero1 = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.Label();
            this.sem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonkol = new System.Windows.Forms.Button();
            this.bucakol = new System.Windows.Forms.Button();
            this.botonpoker = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // varA
            // 
            this.varA.BackColor = System.Drawing.Color.Cornsilk;
            this.varA.ForeColor = System.Drawing.Color.Black;
            this.varA.Location = new System.Drawing.Point(129, 140);
            this.varA.Name = "varA";
            this.varA.Size = new System.Drawing.Size(100, 20);
            this.varA.TabIndex = 1;
            this.varA.TextChanged += new System.EventHandler(this.semilla_TextChanged);
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.Cornsilk;
            this.numero.ForeColor = System.Drawing.Color.Black;
            this.numero.Location = new System.Drawing.Point(130, 187);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 3;
            this.numero.TextChanged += new System.EventHandler(this.numero_TextChanged);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.LightCoral;
            this.calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.White;
            this.calcular.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calcular.Location = new System.Drawing.Point(59, 360);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(97, 33);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Tablas
            // 
            this.Tablas.AllowUserToAddRows = false;
            this.Tablas.AllowUserToDeleteRows = false;
            this.Tablas.BackgroundColor = System.Drawing.Color.White;
            this.Tablas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tsemilla,
            this.elevado,
            this.newsemilla,
            this.Resultado});
            this.Tablas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tablas.Location = new System.Drawing.Point(288, 187);
            this.Tablas.Name = "Tablas";
            this.Tablas.ReadOnly = true;
            this.Tablas.Size = new System.Drawing.Size(447, 219);
            this.Tablas.TabIndex = 8;
            this.Tablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablita_CellContentClick);
            // 
            // Tsemilla
            // 
            this.Tsemilla.HeaderText = "Valor";
            this.Tsemilla.Name = "Tsemilla";
            this.Tsemilla.ReadOnly = true;
            // 
            // elevado
            // 
            this.elevado.HeaderText = "Elevado";
            this.elevado.Name = "elevado";
            this.elevado.ReadOnly = true;
            // 
            // newsemilla
            // 
            this.newsemilla.HeaderText = "Valor 2";
            this.newsemilla.Name = "newsemilla";
            this.newsemilla.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Pseudo";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.LightCoral;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.White;
            this.limpiar.Location = new System.Drawing.Point(59, 414);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(97, 29);
            this.limpiar.TabIndex = 9;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightCoral;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(59, 458);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(97, 29);
            this.salir.TabIndex = 10;
            this.salir.Text = "Menú";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // botonchi
            // 
            this.botonchi.BackColor = System.Drawing.Color.Salmon;
            this.botonchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonchi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonchi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonchi.ForeColor = System.Drawing.Color.White;
            this.botonchi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonchi.Location = new System.Drawing.Point(479, 77);
            this.botonchi.Name = "botonchi";
            this.botonchi.Size = new System.Drawing.Size(120, 33);
            this.botonchi.TabIndex = 11;
            this.botonchi.Text = "Prueba chi";
            this.botonchi.UseVisualStyleBackColor = false;
            this.botonchi.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablachi
            // 
            this.tablachi.BackColor = System.Drawing.Color.LightCoral;
            this.tablachi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablachi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tablachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablachi.ForeColor = System.Drawing.Color.White;
            this.tablachi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tablachi.Location = new System.Drawing.Point(524, 461);
            this.tablachi.Name = "tablachi";
            this.tablachi.Size = new System.Drawing.Size(187, 33);
            this.tablachi.TabIndex = 12;
            this.tablachi.Text = "Prueba Chi Cuadrada";
            this.tablachi.UseVisualStyleBackColor = false;
            this.tablachi.Click += new System.EventHandler(this.tablachi_Click);
            // 
            // confianza
            // 
            this.confianza.AutoSize = true;
            this.confianza.BackColor = System.Drawing.Color.RosyBrown;
            this.confianza.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confianza.ForeColor = System.Drawing.Color.White;
            this.confianza.Location = new System.Drawing.Point(9, 243);
            this.confianza.Name = "confianza";
            this.confianza.Size = new System.Drawing.Size(108, 42);
            this.confianza.TabIndex = 13;
            this.confianza.Text = "Nivel \r\nde confianza";
            this.confianza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // busquedaconfianza
            // 
            this.busquedaconfianza.BackColor = System.Drawing.Color.Cornsilk;
            this.busquedaconfianza.ForeColor = System.Drawing.Color.Black;
            this.busquedaconfianza.Location = new System.Drawing.Point(130, 247);
            this.busquedaconfianza.Name = "busquedaconfianza";
            this.busquedaconfianza.Size = new System.Drawing.Size(100, 20);
            this.busquedaconfianza.TabIndex = 15;
            this.busquedaconfianza.TextChanged += new System.EventHandler(this.busquedaconfianza_TextChanged);
            // 
            // letrero1
            // 
            this.letrero1.AutoSize = true;
            this.letrero1.BackColor = System.Drawing.Color.Transparent;
            this.letrero1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letrero1.ForeColor = System.Drawing.Color.DimGray;
            this.letrero1.Location = new System.Drawing.Point(282, 120);
            this.letrero1.Name = "letrero1";
            this.letrero1.Size = new System.Drawing.Size(0, 24);
            this.letrero1.TabIndex = 16;
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.BackColor = System.Drawing.Color.DimGray;
            this.respuesta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.ForeColor = System.Drawing.Color.Black;
            this.respuesta.Location = new System.Drawing.Point(282, 168);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(0, 28);
            this.respuesta.TabIndex = 17;
            this.respuesta.Click += new System.EventHandler(this.respuesta_Click);
            // 
            // sem
            // 
            this.sem.AutoSize = true;
            this.sem.BackColor = System.Drawing.Color.RosyBrown;
            this.sem.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem.ForeColor = System.Drawing.Color.White;
            this.sem.Location = new System.Drawing.Point(93, 140);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(24, 24);
            this.sem.TabIndex = 18;
            this.sem.Text = "a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "Número \r\nde datos";
            // 
            // botonkol
            // 
            this.botonkol.BackColor = System.Drawing.Color.Salmon;
            this.botonkol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonkol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonkol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonkol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonkol.ForeColor = System.Drawing.Color.White;
            this.botonkol.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonkol.Location = new System.Drawing.Point(629, 62);
            this.botonkol.Name = "botonkol";
            this.botonkol.Size = new System.Drawing.Size(120, 33);
            this.botonkol.TabIndex = 22;
            this.botonkol.Text = "kolmogorov";
            this.botonkol.UseVisualStyleBackColor = false;
            this.botonkol.Click += new System.EventHandler(this.botonkol_Click);
            // 
            // bucakol
            // 
            this.bucakol.BackColor = System.Drawing.Color.LightCoral;
            this.bucakol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bucakol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bucakol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucakol.ForeColor = System.Drawing.Color.White;
            this.bucakol.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bucakol.Location = new System.Drawing.Point(287, 461);
            this.bucakol.Name = "bucakol";
            this.bucakol.Size = new System.Drawing.Size(181, 33);
            this.bucakol.TabIndex = 23;
            this.bucakol.Text = "Prueba Kolmogorov";
            this.bucakol.UseVisualStyleBackColor = false;
            this.bucakol.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // botonpoker
            // 
            this.botonpoker.BackColor = System.Drawing.Color.Salmon;
            this.botonpoker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonpoker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonpoker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonpoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonpoker.ForeColor = System.Drawing.Color.White;
            this.botonpoker.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonpoker.Location = new System.Drawing.Point(629, 108);
            this.botonpoker.Name = "botonpoker";
            this.botonpoker.Size = new System.Drawing.Size(120, 33);
            this.botonpoker.TabIndex = 24;
            this.botonpoker.Text = "Poker";
            this.botonpoker.UseVisualStyleBackColor = false;
            this.botonpoker.Click += new System.EventHandler(this.botonpoker_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "PRUEBAS ESTADISTICAS";
            // 
            // cuadradomedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonpoker);
            this.Controls.Add(this.bucakol);
            this.Controls.Add(this.botonkol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.letrero1);
            this.Controls.Add(this.busquedaconfianza);
            this.Controls.Add(this.confianza);
            this.Controls.Add(this.tablachi);
            this.Controls.Add(this.botonchi);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.varA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "cuadradomedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.scroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox varA;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.DataGridView Tablas;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button botonchi;
        private System.Windows.Forms.Button tablachi;
        private System.Windows.Forms.Label confianza;
        private System.Windows.Forms.TextBox busquedaconfianza;
        private System.Windows.Forms.Label letrero1;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Label sem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonkol;
        private System.Windows.Forms.Button bucakol;
        private System.Windows.Forms.Button botonpoker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tsemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn elevado;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.Label label2;
    }
}

