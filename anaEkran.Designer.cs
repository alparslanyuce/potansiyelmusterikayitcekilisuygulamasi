namespace promosyonTakip.UI.Musteri
{
    partial class anaEkran
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
            this.gpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chkSmsOnay = new System.Windows.Forms.CheckBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hediyepanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chkepostaOnay = new System.Windows.Forms.CheckBox();
            this.gpMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMusteriBilgileri
            // 
            this.gpMusteriBilgileri.Controls.Add(this.btnIptal);
            this.gpMusteriBilgileri.Controls.Add(this.btnKaydet);
            this.gpMusteriBilgileri.Controls.Add(this.chkepostaOnay);
            this.gpMusteriBilgileri.Controls.Add(this.chkSmsOnay);
            this.gpMusteriBilgileri.Controls.Add(this.cmbCinsiyet);
            this.gpMusteriBilgileri.Controls.Add(this.txtDogumTarih);
            this.gpMusteriBilgileri.Controls.Add(this.label5);
            this.gpMusteriBilgileri.Controls.Add(this.label4);
            this.gpMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.gpMusteriBilgileri.Controls.Add(this.label8);
            this.gpMusteriBilgileri.Controls.Add(this.txtEmail);
            this.gpMusteriBilgileri.Controls.Add(this.label7);
            this.gpMusteriBilgileri.Controls.Add(this.txtMeslek);
            this.gpMusteriBilgileri.Controls.Add(this.label6);
            this.gpMusteriBilgileri.Controls.Add(this.txtSoyisim);
            this.gpMusteriBilgileri.Controls.Add(this.label3);
            this.gpMusteriBilgileri.Controls.Add(this.txtIsim);
            this.gpMusteriBilgileri.Controls.Add(this.label2);
            this.gpMusteriBilgileri.Controls.Add(this.txtTcKimlikNo);
            this.gpMusteriBilgileri.Controls.Add(this.label1);
            this.gpMusteriBilgileri.Location = new System.Drawing.Point(507, 12);
            this.gpMusteriBilgileri.Name = "gpMusteriBilgileri";
            this.gpMusteriBilgileri.Size = new System.Drawing.Size(288, 426);
            this.gpMusteriBilgileri.TabIndex = 0;
            this.gpMusteriBilgileri.TabStop = false;
            this.gpMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(116, 356);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(155, 36);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(116, 313);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(154, 36);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chkSmsOnay
            // 
            this.chkSmsOnay.AutoSize = true;
            this.chkSmsOnay.Location = new System.Drawing.Point(116, 289);
            this.chkSmsOnay.Name = "chkSmsOnay";
            this.chkSmsOnay.Size = new System.Drawing.Size(154, 17);
            this.chkSmsOnay.TabIndex = 9;
            this.chkSmsOnay.Text = "Sms bildirim almak istiyorum";
            this.chkSmsOnay.UseVisualStyleBackColor = true;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(116, 161);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(155, 21);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarih.Location = new System.Drawing.Point(116, 135);
            this.txtDogumTarih.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarih.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(155, 20);
            this.txtDogumTarih.TabIndex = 3;
            this.txtDogumTarih.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarih";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(116, 263);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(155, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefon";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email Adres";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(116, 188);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(155, 20);
            this.txtMeslek.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meslek";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(116, 109);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(155, 20);
            this.txtSoyisim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(115, 83);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(155, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(116, 57);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(155, 20);
            this.txtTcKimlikNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarası";
            // 
            // hediyepanel
            // 
            this.hediyepanel.Location = new System.Drawing.Point(13, 12);
            this.hediyepanel.Name = "hediyepanel";
            this.hediyepanel.Size = new System.Drawing.Size(488, 426);
            this.hediyepanel.TabIndex = 1;
            // 
            // chkepostaOnay
            // 
            this.chkepostaOnay.AutoSize = true;
            this.chkepostaOnay.Location = new System.Drawing.Point(115, 240);
            this.chkepostaOnay.Name = "chkepostaOnay";
            this.chkepostaOnay.Size = new System.Drawing.Size(170, 17);
            this.chkepostaOnay.TabIndex = 7;
            this.chkepostaOnay.Text = "Telefon bildirim almak istiyorum";
            this.chkepostaOnay.UseVisualStyleBackColor = true;
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hediyepanel);
            this.Controls.Add(this.gpMusteriBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "anaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promosyon Müşteri Takip Ekranı ";
            this.Load += new System.EventHandler(this.anaEkran_Load);
            this.gpMusteriBilgileri.ResumeLayout(false);
            this.gpMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMusteriBilgileri;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSmsOnay;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker txtDogumTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.FlowLayoutPanel hediyepanel;
        private System.Windows.Forms.CheckBox chkepostaOnay;
    }
}