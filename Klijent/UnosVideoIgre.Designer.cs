namespace Klijent
{
    partial class UnosVideoIgre
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbVideoIgra = new System.Windows.Forms.GroupBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.gbVideoIgra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(62, 20);
            this.txtID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kreiraj video igru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.gbVideoIgra.Enabled = false;
            this.gbVideoIgra.Location = new System.Drawing.Point(15, 52);
            this.gbVideoIgra.Name = "gbVideoIgra";
            this.gbVideoIgra.Size = new System.Drawing.Size(344, 309);
            this.gbVideoIgra.TabIndex = 3;
            this.gbVideoIgra.TabStop = false;
            this.gbVideoIgra.Text = "Unos podataka o novoj video igri";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Odustani";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zapamti video igru";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbPlatforma
            // 
            this.cmbPlatforma.FormattingEnabled = true;
            this.cmbPlatforma.Location = new System.Drawing.Point(92, 170);
            this.cmbPlatforma.Name = "cmbPlatforma";
            this.cmbPlatforma.Size = new System.Drawing.Size(231, 21);
            this.cmbPlatforma.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DIN";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(92, 134);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(105, 20);
            this.txtCena.TabIndex = 3;
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(92, 65);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(231, 53);
            this.txtOpis.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Platforma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(92, 30);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(231, 20);
            this.txtNaslov.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naslov:";
            // 
            // UnosVideoIgre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 373);
            this.Controls.Add(this.gbVideoIgra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "UnosVideoIgre";
            this.Text = "Unos video igre";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnosVideoIgre_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVideoIgra.ResumeLayout(false);
            this.gbVideoIgra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbVideoIgra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbPlatforma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

