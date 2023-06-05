namespace Generador_PseudoA
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Limpiar1 = new System.Windows.Forms.Button();
            this.Generar1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tablaPseudo1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PseudoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.canNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.varXr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.varM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.varC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.varA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPseudo1)).BeginInit();
            this.SuspendLayout();
            // 
            // Limpiar1
            // 
            this.Limpiar1.BackColor = System.Drawing.Color.MistyRose;
            this.Limpiar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpiar1.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.Limpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar1.Location = new System.Drawing.Point(366, 313);
            this.Limpiar1.Name = "Limpiar1";
            this.Limpiar1.Size = new System.Drawing.Size(100, 30);
            this.Limpiar1.TabIndex = 45;
            this.Limpiar1.Text = "Limpiar";
            this.Limpiar1.UseVisualStyleBackColor = false;
            this.Limpiar1.Click += new System.EventHandler(this.Limpiar1_Click);
            // 
            // Generar1
            // 
            this.Generar1.BackColor = System.Drawing.Color.MistyRose;
            this.Generar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generar1.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.Generar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar1.Location = new System.Drawing.Point(220, 313);
            this.Generar1.Name = "Generar1";
            this.Generar1.Size = new System.Drawing.Size(100, 30);
            this.Generar1.TabIndex = 44;
            this.Generar1.Text = "Generar";
            this.Generar1.UseVisualStyleBackColor = false;
            this.Generar1.Click += new System.EventHandler(this.Generar1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "NÚMEROS PSEUDOALEATORIOS";
            // 
            // tablaPseudo1
            // 
            this.tablaPseudo1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.tablaPseudo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaPseudo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPseudo1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.PseudoA});
            this.tablaPseudo1.GridColor = System.Drawing.Color.LightCoral;
            this.tablaPseudo1.Location = new System.Drawing.Point(220, 144);
            this.tablaPseudo1.Name = "tablaPseudo1";
            this.tablaPseudo1.Size = new System.Drawing.Size(246, 150);
            this.tablaPseudo1.TabIndex = 42;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "#";
            this.Cantidad.Name = "Cantidad";
            // 
            // PseudoA
            // 
            this.PseudoA.HeaderText = "Cifra";
            this.PseudoA.Name = "PseudoA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cantidad de números:";
            // 
            // canNum
            // 
            this.canNum.Location = new System.Drawing.Point(95, 270);
            this.canNum.Name = "canNum";
            this.canNum.Size = new System.Drawing.Size(74, 20);
            this.canNum.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Xr:";
            // 
            // varXr
            // 
            this.varXr.Location = new System.Drawing.Point(95, 219);
            this.varXr.Name = "varXr";
            this.varXr.Size = new System.Drawing.Size(74, 20);
            this.varXr.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "m:";
            // 
            // varM
            // 
            this.varM.Location = new System.Drawing.Point(95, 193);
            this.varM.Name = "varM";
            this.varM.Size = new System.Drawing.Size(74, 20);
            this.varM.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "c:";
            // 
            // varC
            // 
            this.varC.Location = new System.Drawing.Point(95, 167);
            this.varC.Name = "varC";
            this.varC.Size = new System.Drawing.Size(74, 20);
            this.varC.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "a:";
            // 
            // varA
            // 
            this.varA.Location = new System.Drawing.Point(95, 141);
            this.varA.Name = "varA";
            this.varA.Size = new System.Drawing.Size(74, 20);
            this.varA.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 34);
            this.label1.TabIndex = 31;
            this.label1.Text = "Generador de números Pseudoaleatorios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Limpiar1);
            this.Controls.Add(this.Generar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tablaPseudo1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.canNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.varXr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.varM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.varA);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(641, 373);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPseudo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpiar1;
        private System.Windows.Forms.Button Generar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tablaPseudo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PseudoA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox canNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox varXr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox varM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox varC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox varA;
        private System.Windows.Forms.Label label1;
    }
}
