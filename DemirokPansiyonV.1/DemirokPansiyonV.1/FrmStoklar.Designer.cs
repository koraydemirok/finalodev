
namespace DemirokPansiyonV._1
{
    partial class FrmStoklar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGidalar = new System.Windows.Forms.TextBox();
            this.TxtIcecekler = new System.Windows.Forms.TextBox();
            this.TxtAtistirmaliklar = new System.Windows.Forms.TextBox();
            this.BtnStokKaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Gıdalar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İçecekler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Atıştırmalıklar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalıklar:";
            // 
            // TxtGidalar
            // 
            this.TxtGidalar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGidalar.Location = new System.Drawing.Point(181, 49);
            this.TxtGidalar.Name = "TxtGidalar";
            this.TxtGidalar.Size = new System.Drawing.Size(164, 27);
            this.TxtGidalar.TabIndex = 3;
            // 
            // TxtIcecekler
            // 
            this.TxtIcecekler.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIcecekler.Location = new System.Drawing.Point(181, 90);
            this.TxtIcecekler.Name = "TxtIcecekler";
            this.TxtIcecekler.Size = new System.Drawing.Size(164, 27);
            this.TxtIcecekler.TabIndex = 4;
            // 
            // TxtAtistirmaliklar
            // 
            this.TxtAtistirmaliklar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAtistirmaliklar.Location = new System.Drawing.Point(181, 130);
            this.TxtAtistirmaliklar.Name = "TxtAtistirmaliklar";
            this.TxtAtistirmaliklar.Size = new System.Drawing.Size(164, 27);
            this.TxtAtistirmaliklar.TabIndex = 5;
            // 
            // BtnStokKaydet
            // 
            this.BtnStokKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStokKaydet.Location = new System.Drawing.Point(214, 175);
            this.BtnStokKaydet.Name = "BtnStokKaydet";
            this.BtnStokKaydet.Size = new System.Drawing.Size(103, 55);
            this.BtnStokKaydet.TabIndex = 6;
            this.BtnStokKaydet.Text = "Kaydet";
            this.BtnStokKaydet.UseVisualStyleBackColor = true;
            this.BtnStokKaydet.Click += new System.EventHandler(this.BtnStokKaydet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gıdalar,
            this.İçecekler,
            this.Atıştırmalıklar});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 303);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 146);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Gıdalar
            // 
            this.Gıdalar.Text = "Gıdalar";
            this.Gıdalar.Width = 142;
            // 
            // İçecekler
            // 
            this.İçecekler.Text = "İçecekler";
            this.İçecekler.Width = 127;
            // 
            // Atıştırmalıklar
            // 
            this.Atıştırmalıklar.Text = "Atıştırmalıklar";
            this.Atıştırmalıklar.Width = 154;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnStokKaydet);
            this.Controls.Add(this.TxtAtistirmaliklar);
            this.Controls.Add(this.TxtIcecekler);
            this.Controls.Add(this.TxtGidalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGidalar;
        private System.Windows.Forms.TextBox TxtIcecekler;
        private System.Windows.Forms.TextBox TxtAtistirmaliklar;
        private System.Windows.Forms.Button BtnStokKaydet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Gıdalar;
        private System.Windows.Forms.ColumnHeader İçecekler;
        private System.Windows.Forms.ColumnHeader Atıştırmalıklar;
    }
}