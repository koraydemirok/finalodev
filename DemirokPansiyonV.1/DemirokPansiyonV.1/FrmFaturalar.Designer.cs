
namespace DemirokPansiyonV._1
{
    partial class FrmFaturalar
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
            this.BtnFaturaKaydet = new System.Windows.Forms.Button();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnFaturaKaydet
            // 
            this.BtnFaturaKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFaturaKaydet.Location = new System.Drawing.Point(135, 161);
            this.BtnFaturaKaydet.Name = "BtnFaturaKaydet";
            this.BtnFaturaKaydet.Size = new System.Drawing.Size(103, 55);
            this.BtnFaturaKaydet.TabIndex = 13;
            this.BtnFaturaKaydet.Text = "Kaydet";
            this.BtnFaturaKaydet.UseVisualStyleBackColor = true;
            this.BtnFaturaKaydet.Click += new System.EventHandler(this.BtnFaturaKaydet_Click);
            // 
            // TxtInternet
            // 
            this.TxtInternet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtInternet.Location = new System.Drawing.Point(103, 118);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(164, 27);
            this.TxtInternet.TabIndex = 12;
            // 
            // TxtSu
            // 
            this.TxtSu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSu.Location = new System.Drawing.Point(103, 76);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(164, 27);
            this.TxtSu.TabIndex = 11;
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtElektrik.Location = new System.Drawing.Point(103, 37);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(164, 27);
            this.TxtElektrik.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "İnternet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Su:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elektrik:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 292);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 158);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Elektrik";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Su";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İnternet";
            this.columnHeader3.Width = 111;
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnFaturaKaydet);
            this.Controls.Add(this.TxtInternet);
            this.Controls.Add(this.TxtSu);
            this.Controls.Add(this.TxtElektrik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFaturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFaturaKaydet;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}