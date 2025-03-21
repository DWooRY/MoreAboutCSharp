namespace SystemIOWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Personel = new System.Windows.Forms.ListBox();
            this.btn_personelGetir = new System.Windows.Forms.Button();
            this.btn_personelKaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txt_ulke = new System.Windows.Forms.TextBox();
            this.txt_firmaAdi = new System.Windows.Forms.TextBox();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Personel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Liste";
            // 
            // lst_Personel
            // 
            this.lst_Personel.FormattingEnabled = true;
            this.lst_Personel.Location = new System.Drawing.Point(6, 19);
            this.lst_Personel.Name = "lst_Personel";
            this.lst_Personel.Size = new System.Drawing.Size(167, 238);
            this.lst_Personel.TabIndex = 0;
            this.lst_Personel.SelectedIndexChanged += new System.EventHandler(this.lst_Personel_SelectedIndexChanged);
            // 
            // btn_personelGetir
            // 
            this.btn_personelGetir.Location = new System.Drawing.Point(204, 177);
            this.btn_personelGetir.Name = "btn_personelGetir";
            this.btn_personelGetir.Size = new System.Drawing.Size(240, 46);
            this.btn_personelGetir.TabIndex = 1;
            this.btn_personelGetir.Text = " Personel Getir";
            this.btn_personelGetir.UseVisualStyleBackColor = true;
            this.btn_personelGetir.Click += new System.EventHandler(this.btn_personelGetir_Click);
            // 
            // btn_personelKaydet
            // 
            this.btn_personelKaydet.Location = new System.Drawing.Point(204, 229);
            this.btn_personelKaydet.Name = "btn_personelKaydet";
            this.btn_personelKaydet.Size = new System.Drawing.Size(240, 46);
            this.btn_personelKaydet.TabIndex = 1;
            this.btn_personelKaydet.Text = " Personel Kaydet";
            this.btn_personelKaydet.UseVisualStyleBackColor = true;
            this.btn_personelKaydet.Click += new System.EventHandler(this.btn_personelKaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.txt_ulke);
            this.groupBox2.Controls.Add(this.txt_firmaAdi);
            this.groupBox2.Controls.Add(this.txt_emailAdres);
            this.groupBox2.Controls.Add(this.txt_soyisim);
            this.groupBox2.Controls.Add(this.txt_isim);
            this.groupBox2.Location = new System.Drawing.Point(197, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ülke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Firma Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(25, 13);
            this.label.TabIndex = 1;
            this.label.Text = "İsim";
            // 
            // txt_ulke
            // 
            this.txt_ulke.Location = new System.Drawing.Point(83, 123);
            this.txt_ulke.Name = "txt_ulke";
            this.txt_ulke.Size = new System.Drawing.Size(157, 20);
            this.txt_ulke.TabIndex = 0;
            // 
            // txt_firmaAdi
            // 
            this.txt_firmaAdi.Location = new System.Drawing.Point(83, 97);
            this.txt_firmaAdi.Name = "txt_firmaAdi";
            this.txt_firmaAdi.Size = new System.Drawing.Size(157, 20);
            this.txt_firmaAdi.TabIndex = 0;
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(83, 71);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(157, 20);
            this.txt_emailAdres.TabIndex = 0;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(83, 45);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(157, 20);
            this.txt_soyisim.TabIndex = 0;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(83, 19);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(157, 20);
            this.txt_isim.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_personelKaydet);
            this.Controls.Add(this.btn_personelGetir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System IO Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_personelGetir;
        private System.Windows.Forms.ListBox lst_Personel;
        private System.Windows.Forms.Button btn_personelKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ulke;
        private System.Windows.Forms.TextBox txt_firmaAdi;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.TextBox txt_soyisim;
    }
}

