﻿
namespace DemirokPansiyonV._1
{
    partial class FrmYeniMusteri
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
            this.BtnYeniTemizle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOda109 = new System.Windows.Forms.Button();
            this.BtnOda108 = new System.Windows.Forms.Button();
            this.BtnOda107 = new System.Windows.Forms.Button();
            this.BtnOda106 = new System.Windows.Forms.Button();
            this.BtnOda105 = new System.Windows.Forms.Button();
            this.BtnOda104 = new System.Windows.Forms.Button();
            this.BtnOda103 = new System.Windows.Forms.Button();
            this.BtnOda102 = new System.Windows.Forms.Button();
            this.BtnOda101 = new System.Windows.Forms.Button();
            this.BtnBosOda = new System.Windows.Forms.Button();
            this.BtnDoluOda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnYeniTemizle);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.TxtOdaNo);
            this.groupBox1.Controls.Add(this.TxtKimlikNo);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // BtnYeniTemizle
            // 
            this.BtnYeniTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniTemizle.Location = new System.Drawing.Point(145, 374);
            this.BtnYeniTemizle.Name = "BtnYeniTemizle";
            this.BtnYeniTemizle.Size = new System.Drawing.Size(116, 49);
            this.BtnYeniTemizle.TabIndex = 39;
            this.BtnYeniTemizle.Text = "Temizle";
            this.BtnYeniTemizle.UseVisualStyleBackColor = true;
            this.BtnYeniTemizle.Click += new System.EventHandler(this.BtnYeniTemizle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(422, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(157, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 28);
            this.comboBox1.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(80, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 36;
            this.label10.Text = "Cinsiyet:";
            // 
            // TxtUcret
            // 
            this.TxtUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.Location = new System.Drawing.Point(157, 263);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(284, 27);
            this.TxtUcret.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(97, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ücret:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(276, 374);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(116, 49);
            this.BtnKaydet.TabIndex = 33;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Location = new System.Drawing.Point(157, 329);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(284, 27);
            this.DtpCikisTarihi.TabIndex = 32;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Location = new System.Drawing.Point(157, 296);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(284, 27);
            this.DtpGirisTarihi.TabIndex = 31;
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(157, 131);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(284, 27);
            this.MskTxtTelefon.TabIndex = 30;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Enabled = false;
            this.TxtOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdaNo.Location = new System.Drawing.Point(157, 230);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(284, 27);
            this.TxtOdaNo.TabIndex = 29;
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKimlikNo.Location = new System.Drawing.Point(157, 197);
            this.TxtKimlikNo.MaxLength = 11;
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(284, 27);
            this.TxtKimlikNo.TabIndex = 28;
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(157, 164);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(284, 27);
            this.TxtMail.TabIndex = 27;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadi.Location = new System.Drawing.Point(157, 64);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(284, 27);
            this.TxtSoyadi.TabIndex = 26;
            // 
            // TxtAdi
            // 
            this.TxtAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Location = new System.Drawing.Point(157, 31);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(284, 27);
            this.TxtAdi.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(35, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Oda Numarası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(63, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOda109);
            this.groupBox2.Controls.Add(this.BtnOda108);
            this.groupBox2.Controls.Add(this.BtnOda107);
            this.groupBox2.Controls.Add(this.BtnOda106);
            this.groupBox2.Controls.Add(this.BtnOda105);
            this.groupBox2.Controls.Add(this.BtnOda104);
            this.groupBox2.Controls.Add(this.BtnOda103);
            this.groupBox2.Controls.Add(this.BtnOda102);
            this.groupBox2.Controls.Add(this.BtnOda101);
            this.groupBox2.Location = new System.Drawing.Point(519, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // BtnOda109
            // 
            this.BtnOda109.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda109.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda109.Location = new System.Drawing.Point(316, 246);
            this.BtnOda109.Name = "BtnOda109";
            this.BtnOda109.Size = new System.Drawing.Size(52, 38);
            this.BtnOda109.TabIndex = 8;
            this.BtnOda109.Text = "109";
            this.BtnOda109.UseVisualStyleBackColor = false;
            this.BtnOda109.Click += new System.EventHandler(this.BtnOda109_Click);
            // 
            // BtnOda108
            // 
            this.BtnOda108.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda108.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda108.Location = new System.Drawing.Point(193, 246);
            this.BtnOda108.Name = "BtnOda108";
            this.BtnOda108.Size = new System.Drawing.Size(52, 38);
            this.BtnOda108.TabIndex = 7;
            this.BtnOda108.Text = "108";
            this.BtnOda108.UseVisualStyleBackColor = false;
            this.BtnOda108.Click += new System.EventHandler(this.BtnOda108_Click);
            // 
            // BtnOda107
            // 
            this.BtnOda107.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda107.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda107.Location = new System.Drawing.Point(61, 246);
            this.BtnOda107.Name = "BtnOda107";
            this.BtnOda107.Size = new System.Drawing.Size(52, 38);
            this.BtnOda107.TabIndex = 6;
            this.BtnOda107.Text = "107";
            this.BtnOda107.UseVisualStyleBackColor = false;
            this.BtnOda107.Click += new System.EventHandler(this.BtnOda107_Click);
            // 
            // BtnOda106
            // 
            this.BtnOda106.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda106.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda106.Location = new System.Drawing.Point(316, 169);
            this.BtnOda106.Name = "BtnOda106";
            this.BtnOda106.Size = new System.Drawing.Size(52, 38);
            this.BtnOda106.TabIndex = 5;
            this.BtnOda106.Text = "106";
            this.BtnOda106.UseVisualStyleBackColor = false;
            this.BtnOda106.Click += new System.EventHandler(this.BtnOda106_Click);
            // 
            // BtnOda105
            // 
            this.BtnOda105.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda105.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda105.Location = new System.Drawing.Point(193, 169);
            this.BtnOda105.Name = "BtnOda105";
            this.BtnOda105.Size = new System.Drawing.Size(52, 38);
            this.BtnOda105.TabIndex = 4;
            this.BtnOda105.Text = "105";
            this.BtnOda105.UseVisualStyleBackColor = false;
            this.BtnOda105.Click += new System.EventHandler(this.BtnOda105_Click);
            // 
            // BtnOda104
            // 
            this.BtnOda104.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda104.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda104.Location = new System.Drawing.Point(61, 169);
            this.BtnOda104.Name = "BtnOda104";
            this.BtnOda104.Size = new System.Drawing.Size(52, 38);
            this.BtnOda104.TabIndex = 3;
            this.BtnOda104.Text = "104";
            this.BtnOda104.UseVisualStyleBackColor = false;
            this.BtnOda104.Click += new System.EventHandler(this.BtnOda104_Click);
            // 
            // BtnOda103
            // 
            this.BtnOda103.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda103.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda103.Location = new System.Drawing.Point(316, 97);
            this.BtnOda103.Name = "BtnOda103";
            this.BtnOda103.Size = new System.Drawing.Size(52, 38);
            this.BtnOda103.TabIndex = 2;
            this.BtnOda103.Text = "103";
            this.BtnOda103.UseVisualStyleBackColor = false;
            this.BtnOda103.Click += new System.EventHandler(this.BtnOda103_Click);
            // 
            // BtnOda102
            // 
            this.BtnOda102.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda102.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda102.Location = new System.Drawing.Point(193, 99);
            this.BtnOda102.Name = "BtnOda102";
            this.BtnOda102.Size = new System.Drawing.Size(52, 38);
            this.BtnOda102.TabIndex = 1;
            this.BtnOda102.Text = "102";
            this.BtnOda102.UseVisualStyleBackColor = false;
            this.BtnOda102.Click += new System.EventHandler(this.BtnOda102_Click);
            // 
            // BtnOda101
            // 
            this.BtnOda101.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOda101.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOda101.Location = new System.Drawing.Point(61, 99);
            this.BtnOda101.Name = "BtnOda101";
            this.BtnOda101.Size = new System.Drawing.Size(52, 38);
            this.BtnOda101.TabIndex = 0;
            this.BtnOda101.Text = "101";
            this.BtnOda101.UseVisualStyleBackColor = false;
            this.BtnOda101.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnBosOda
            // 
            this.BtnBosOda.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnBosOda.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBosOda.Location = new System.Drawing.Point(835, 469);
            this.BtnBosOda.Name = "BtnBosOda";
            this.BtnBosOda.Size = new System.Drawing.Size(52, 38);
            this.BtnBosOda.TabIndex = 9;
            this.BtnBosOda.Text = "Boş";
            this.BtnBosOda.UseVisualStyleBackColor = false;
            this.BtnBosOda.Click += new System.EventHandler(this.BtnBosOda_Click);
            // 
            // BtnDoluOda
            // 
            this.BtnDoluOda.BackColor = System.Drawing.Color.Red;
            this.BtnDoluOda.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoluOda.Location = new System.Drawing.Point(767, 469);
            this.BtnDoluOda.Name = "BtnDoluOda";
            this.BtnDoluOda.Size = new System.Drawing.Size(52, 38);
            this.BtnDoluOda.TabIndex = 8;
            this.BtnDoluOda.Text = "Dolu";
            this.BtnDoluOda.UseVisualStyleBackColor = false;
            this.BtnDoluOda.Click += new System.EventHandler(this.BtnDoluOda_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(935, 520);
            this.Controls.Add(this.BtnBosOda);
            this.Controls.Add(this.BtnDoluOda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniMusteri";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.FrmYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.TextBox TxtKimlikNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOda109;
        private System.Windows.Forms.Button BtnOda108;
        private System.Windows.Forms.Button BtnOda107;
        private System.Windows.Forms.Button BtnOda106;
        private System.Windows.Forms.Button BtnOda105;
        private System.Windows.Forms.Button BtnOda104;
        private System.Windows.Forms.Button BtnOda103;
        private System.Windows.Forms.Button BtnOda102;
        private System.Windows.Forms.Button BtnOda101;
        private System.Windows.Forms.Button BtnBosOda;
        private System.Windows.Forms.Button BtnDoluOda;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnYeniTemizle;
    }
}