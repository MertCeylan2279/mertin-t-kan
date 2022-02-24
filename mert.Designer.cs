namespace WindowsFormsApplication39
{
    partial class Form1
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
            this.btnAEkle = new System.Windows.Forms.Button();
            this.btnLEkle = new System.Windows.Forms.Button();
            this.btnATopla = new System.Windows.Forms.Button();
            this.btnLTopla = new System.Windows.Forms.Button();
            this.btnAYaz = new System.Windows.Forms.Button();
            this.btnLYaz = new System.Windows.Forms.Button();
            this.btnABul = new System.Windows.Forms.Button();
            this.btnLBul = new System.Windows.Forms.Button();
            this.lblAEkle = new System.Windows.Forms.Label();
            this.lblLEkle = new System.Windows.Forms.Label();
            this.lblATopla = new System.Windows.Forms.Label();
            this.lblLTopla = new System.Windows.Forms.Label();
            this.lblAYaz = new System.Windows.Forms.Label();
            this.lblLYaz = new System.Windows.Forms.Label();
            this.lblABul = new System.Windows.Forms.Label();
            this.lblLBul = new System.Windows.Forms.Label();
            this.listeA = new System.Windows.Forms.ListBox();
            this.listeL = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAEkle
            // 
            this.btnAEkle.Location = new System.Drawing.Point(135, 99);
            this.btnAEkle.Name = "btnAEkle";
            this.btnAEkle.Size = new System.Drawing.Size(148, 34);
            this.btnAEkle.TabIndex = 0;
            this.btnAEkle.Text = "ArrayList Değer Ekle";
            this.btnAEkle.UseVisualStyleBackColor = true;
            this.btnAEkle.Click += new System.EventHandler(this.btnAEkle_Click);
            // 
            // btnLEkle
            // 
            this.btnLEkle.Location = new System.Drawing.Point(136, 139);
            this.btnLEkle.Name = "btnLEkle";
            this.btnLEkle.Size = new System.Drawing.Size(148, 34);
            this.btnLEkle.TabIndex = 1;
            this.btnLEkle.Text = "List Değer Ekle";
            this.btnLEkle.UseVisualStyleBackColor = true;
            this.btnLEkle.Click += new System.EventHandler(this.btnLEkle_Click);
            // 
            // btnATopla
            // 
            this.btnATopla.Location = new System.Drawing.Point(135, 179);
            this.btnATopla.Name = "btnATopla";
            this.btnATopla.Size = new System.Drawing.Size(148, 34);
            this.btnATopla.TabIndex = 2;
            this.btnATopla.Text = "ArrayList Değer Topla";
            this.btnATopla.UseVisualStyleBackColor = true;
            this.btnATopla.Click += new System.EventHandler(this.btnATopla_Click);
            // 
            // btnLTopla
            // 
            this.btnLTopla.Location = new System.Drawing.Point(135, 219);
            this.btnLTopla.Name = "btnLTopla";
            this.btnLTopla.Size = new System.Drawing.Size(148, 34);
            this.btnLTopla.TabIndex = 3;
            this.btnLTopla.Text = "List Değer Topla";
            this.btnLTopla.UseVisualStyleBackColor = true;
            this.btnLTopla.Click += new System.EventHandler(this.btnLTopla_Click);
            // 
            // btnAYaz
            // 
            this.btnAYaz.Location = new System.Drawing.Point(387, 99);
            this.btnAYaz.Name = "btnAYaz";
            this.btnAYaz.Size = new System.Drawing.Size(148, 34);
            this.btnAYaz.TabIndex = 4;
            this.btnAYaz.Text = "ArrayList Değer Yaz\r\n\r\n";
            this.btnAYaz.UseVisualStyleBackColor = true;
            this.btnAYaz.Click += new System.EventHandler(this.btnAYaz_Click);
            // 
            // btnLYaz
            // 
            this.btnLYaz.Location = new System.Drawing.Point(387, 139);
            this.btnLYaz.Name = "btnLYaz";
            this.btnLYaz.Size = new System.Drawing.Size(148, 34);
            this.btnLYaz.TabIndex = 5;
            this.btnLYaz.Text = "List Değer Yaz\r\n";
            this.btnLYaz.UseVisualStyleBackColor = true;
            this.btnLYaz.Click += new System.EventHandler(this.btnLyaz_Click);
            // 
            // btnABul
            // 
            this.btnABul.Location = new System.Drawing.Point(387, 179);
            this.btnABul.Name = "btnABul";
            this.btnABul.Size = new System.Drawing.Size(148, 34);
            this.btnABul.TabIndex = 6;
            this.btnABul.Text = "ArrayList Değer Bul\r\n\r\n ";
            this.btnABul.UseVisualStyleBackColor = true;
            this.btnABul.Click += new System.EventHandler(this.btnABul_Click);
            // 
            // btnLBul
            // 
            this.btnLBul.Location = new System.Drawing.Point(387, 219);
            this.btnLBul.Name = "btnLBul";
            this.btnLBul.Size = new System.Drawing.Size(148, 34);
            this.btnLBul.TabIndex = 7;
            this.btnLBul.Text = "List Değer Bul";
            this.btnLBul.UseVisualStyleBackColor = true;
            this.btnLBul.Click += new System.EventHandler(this.btnLBul_Click);
            // 
            // lblAEkle
            // 
            this.lblAEkle.AutoSize = true;
            this.lblAEkle.Location = new System.Drawing.Point(290, 110);
            this.lblAEkle.Name = "lblAEkle";
            this.lblAEkle.Size = new System.Drawing.Size(35, 13);
            this.lblAEkle.TabIndex = 8;
            this.lblAEkle.Text = "label1";
            // 
            // lblLEkle
            // 
            this.lblLEkle.AutoSize = true;
            this.lblLEkle.Location = new System.Drawing.Point(290, 150);
            this.lblLEkle.Name = "lblLEkle";
            this.lblLEkle.Size = new System.Drawing.Size(35, 13);
            this.lblLEkle.TabIndex = 9;
            this.lblLEkle.Text = "label2";
            // 
            // lblATopla
            // 
            this.lblATopla.AutoSize = true;
            this.lblATopla.Location = new System.Drawing.Point(290, 190);
            this.lblATopla.Name = "lblATopla";
            this.lblATopla.Size = new System.Drawing.Size(35, 13);
            this.lblATopla.TabIndex = 10;
            this.lblATopla.Text = "label3";
            // 
            // lblLTopla
            // 
            this.lblLTopla.AutoSize = true;
            this.lblLTopla.Location = new System.Drawing.Point(290, 230);
            this.lblLTopla.Name = "lblLTopla";
            this.lblLTopla.Size = new System.Drawing.Size(35, 13);
            this.lblLTopla.TabIndex = 11;
            this.lblLTopla.Text = "label4";
            this.lblLTopla.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAYaz
            // 
            this.lblAYaz.AutoSize = true;
            this.lblAYaz.Location = new System.Drawing.Point(541, 110);
            this.lblAYaz.Name = "lblAYaz";
            this.lblAYaz.Size = new System.Drawing.Size(35, 13);
            this.lblAYaz.TabIndex = 12;
            this.lblAYaz.Text = "label5";
            // 
            // lblLYaz
            // 
            this.lblLYaz.AutoSize = true;
            this.lblLYaz.Location = new System.Drawing.Point(541, 150);
            this.lblLYaz.Name = "lblLYaz";
            this.lblLYaz.Size = new System.Drawing.Size(35, 13);
            this.lblLYaz.TabIndex = 13;
            this.lblLYaz.Text = "label6";
            // 
            // lblABul
            // 
            this.lblABul.AutoSize = true;
            this.lblABul.Location = new System.Drawing.Point(541, 190);
            this.lblABul.Name = "lblABul";
            this.lblABul.Size = new System.Drawing.Size(35, 13);
            this.lblABul.TabIndex = 14;
            this.lblABul.Text = "label7";
            // 
            // lblLBul
            // 
            this.lblLBul.AutoSize = true;
            this.lblLBul.Location = new System.Drawing.Point(541, 230);
            this.lblLBul.Name = "lblLBul";
            this.lblLBul.Size = new System.Drawing.Size(35, 13);
            this.lblLBul.TabIndex = 15;
            this.lblLBul.Text = "label8";
            // 
            // listeA
            // 
            this.listeA.FormattingEnabled = true;
            this.listeA.Location = new System.Drawing.Point(603, 99);
            this.listeA.Name = "listeA";
            this.listeA.Size = new System.Drawing.Size(92, 160);
            this.listeA.TabIndex = 16;
            // 
            // listeL
            // 
            this.listeL.FormattingEnabled = true;
            this.listeL.Location = new System.Drawing.Point(701, 99);
            this.listeL.Name = "listeL";
            this.listeL.Size = new System.Drawing.Size(92, 160);
            this.listeL.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(870, 560);
            this.Controls.Add(this.listeL);
            this.Controls.Add(this.listeA);
            this.Controls.Add(this.lblLBul);
            this.Controls.Add(this.lblABul);
            this.Controls.Add(this.lblLYaz);
            this.Controls.Add(this.lblAYaz);
            this.Controls.Add(this.lblLTopla);
            this.Controls.Add(this.lblATopla);
            this.Controls.Add(this.lblLEkle);
            this.Controls.Add(this.lblAEkle);
            this.Controls.Add(this.btnLBul);
            this.Controls.Add(this.btnABul);
            this.Controls.Add(this.btnLYaz);
            this.Controls.Add(this.btnAYaz);
            this.Controls.Add(this.btnLTopla);
            this.Controls.Add(this.btnATopla);
            this.Controls.Add(this.btnLEkle);
            this.Controls.Add(this.btnAEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAEkle;
        private System.Windows.Forms.Button btnLEkle;
        private System.Windows.Forms.Button btnATopla;
        private System.Windows.Forms.Button btnLTopla;
        private System.Windows.Forms.Button btnAYaz;
        private System.Windows.Forms.Button btnLYaz;
        private System.Windows.Forms.Button btnABul;
        private System.Windows.Forms.Button btnLBul;
        private System.Windows.Forms.Label lblAEkle;
        private System.Windows.Forms.Label lblLEkle;
        private System.Windows.Forms.Label lblATopla;
        private System.Windows.Forms.Label lblLTopla;
        private System.Windows.Forms.Label lblAYaz;
        private System.Windows.Forms.Label lblLYaz;
        private System.Windows.Forms.Label lblABul;
        private System.Windows.Forms.Label lblLBul;
        private System.Windows.Forms.ListBox listeA;
        private System.Windows.Forms.ListBox listeL;
    }
}

