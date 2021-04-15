namespace Klijent
{
    partial class DetaljiVideoIgre
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbPlatforma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.gbVideoIgra = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbVideoIgra.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 492);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(610, 75);
            this.button3.TabIndex = 6;
            this.button3.Text = "Obrisi video igru";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 406);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(610, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zapamti video igru";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbPlatforma
            // 
            this.cmbPlatforma.FormattingEnabled = true;
            this.cmbPlatforma.Location = new System.Drawing.Point(184, 327);
            this.cmbPlatforma.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbPlatforma.Name = "cmbPlatforma";
            this.cmbPlatforma.Size = new System.Drawing.Size(458, 33);
            this.cmbPlatforma.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "DIN";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(184, 258);
            this.txtCena.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(206, 31);
            this.txtCena.TabIndex = 3;
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(184, 125);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(458, 98);
            this.txtOpis.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Platforma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cena:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(184, 58);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(458, 31);
            this.txtNaslov.TabIndex = 1;
            // 
            // gbVideoIgra
            // 
            this.gbVideoIgra.Controls.Add(this.button3);
            this.gbVideoIgra.Controls.Add(this.button2);
            this.gbVideoIgra.Controls.Add(this.cmbPlatforma);
            this.gbVideoIgra.Controls.Add(this.label6);
            this.gbVideoIgra.Controls.Add(this.txtCena);
            this.gbVideoIgra.Controls.Add(this.txtOpis);
            this.gbVideoIgra.Controls.Add(this.label5);
            this.gbVideoIgra.Controls.Add(this.label4);
            this.gbVideoIgra.Controls.Add(this.label3);
            this.gbVideoIgra.Controls.Add(this.txtNaslov);
            this.gbVideoIgra.Controls.Add(this.label2);
            this.gbVideoIgra.Location = new System.Drawing.Point(24, 23);
            this.gbVideoIgra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbVideoIgra.Name = "gbVideoIgra";
            this.gbVideoIgra.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbVideoIgra.Size = new System.Drawing.Size(688, 594);
            this.gbVideoIgra.TabIndex = 7;
            this.gbVideoIgra.TabStop = false;
            this.gbVideoIgra.Text = "Izmena podataka o video igri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naslov:";
            // 
            // DetaljiVideoIgre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 642);
            this.Controls.Add(this.gbVideoIgra);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DetaljiVideoIgre";
            this.Text = "Detalji video igre";
            this.Load += new System.EventHandler(this.DetaljiUsluge_Load);
            this.gbVideoIgra.ResumeLayout(false);
            this.gbVideoIgra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbPlatforma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.GroupBox gbVideoIgra;
        private System.Windows.Forms.Label label2;
    }
}