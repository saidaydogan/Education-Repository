namespace veritabanıProje
{
    partial class ÖdemeTakip
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMüsteriFaturalari = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMüsteriİd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.dataGridViewMüsteri = new System.Windows.Forms.DataGridView();
            this.listBoxMüsteri = new System.Windows.Forms.ListBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.panelSiparisFaturalari = new System.Windows.Forms.Panel();
            this.listBoxSiparis = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiparisid = new System.Windows.Forms.TextBox();
            this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
            this.panelMüsteriFaturalari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMüsteri)).BeginInit();
            this.panelSiparisFaturalari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(282, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 22);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sipariş Faturaları";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(152, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 22);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Müşteri Fatuları";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(81, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seçiniz : ";
            // 
            // panelMüsteriFaturalari
            // 
            this.panelMüsteriFaturalari.Controls.Add(this.listBoxMüsteri);
            this.panelMüsteriFaturalari.Controls.Add(this.label1);
            this.panelMüsteriFaturalari.Controls.Add(this.txtMüsteriİd);
            this.panelMüsteriFaturalari.Controls.Add(this.dataGridViewMüsteri);
            this.panelMüsteriFaturalari.Location = new System.Drawing.Point(12, 37);
            this.panelMüsteriFaturalari.Name = "panelMüsteriFaturalari";
            this.panelMüsteriFaturalari.Size = new System.Drawing.Size(491, 206);
            this.panelMüsteriFaturalari.TabIndex = 17;
            this.panelMüsteriFaturalari.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMüsteriFaturlari_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri ID : ";
            // 
            // txtMüsteriİd
            // 
            this.txtMüsteriİd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMüsteriİd.Location = new System.Drawing.Point(209, 8);
            this.txtMüsteriİd.Name = "txtMüsteriİd";
            this.txtMüsteriİd.Size = new System.Drawing.Size(156, 24);
            this.txtMüsteriİd.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(246, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kalan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(233, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ödenen :";
            // 
            // txtOdenen
            // 
            this.txtOdenen.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenen.Location = new System.Drawing.Point(301, 244);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.ReadOnly = true;
            this.txtOdenen.Size = new System.Drawing.Size(156, 24);
            this.txtOdenen.TabIndex = 20;
            // 
            // txtKalan
            // 
            this.txtKalan.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalan.Location = new System.Drawing.Point(301, 288);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.ReadOnly = true;
            this.txtKalan.Size = new System.Drawing.Size(156, 24);
            this.txtKalan.TabIndex = 19;
            // 
            // dataGridViewMüsteri
            // 
            this.dataGridViewMüsteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMüsteri.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewMüsteri.Name = "dataGridViewMüsteri";
            this.dataGridViewMüsteri.Size = new System.Drawing.Size(285, 150);
            this.dataGridViewMüsteri.TabIndex = 0;
            // 
            // listBoxMüsteri
            // 
            this.listBoxMüsteri.FormattingEnabled = true;
            this.listBoxMüsteri.Location = new System.Drawing.Point(294, 41);
            this.listBoxMüsteri.Name = "listBoxMüsteri";
            this.listBoxMüsteri.Size = new System.Drawing.Size(171, 147);
            this.listBoxMüsteri.TabIndex = 23;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(88, 244);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(112, 24);
            this.txtMiktar.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Miktar :";
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(21, 285);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(82, 28);
            this.btnOde.TabIndex = 26;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(109, 285);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(91, 28);
            this.btnİptal.TabIndex = 27;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // panelSiparisFaturalari
            // 
            this.panelSiparisFaturalari.Controls.Add(this.listBoxSiparis);
            this.panelSiparisFaturalari.Controls.Add(this.label3);
            this.panelSiparisFaturalari.Controls.Add(this.txtSiparisid);
            this.panelSiparisFaturalari.Controls.Add(this.dataGridViewSiparis);
            this.panelSiparisFaturalari.Location = new System.Drawing.Point(12, 37);
            this.panelSiparisFaturalari.Name = "panelSiparisFaturalari";
            this.panelSiparisFaturalari.Size = new System.Drawing.Size(491, 206);
            this.panelSiparisFaturalari.TabIndex = 24;
            // 
            // listBoxSiparis
            // 
            this.listBoxSiparis.FormattingEnabled = true;
            this.listBoxSiparis.Location = new System.Drawing.Point(294, 41);
            this.listBoxSiparis.Name = "listBoxSiparis";
            this.listBoxSiparis.Size = new System.Drawing.Size(171, 147);
            this.listBoxSiparis.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(117, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sipariş ID : ";
            // 
            // txtSiparisid
            // 
            this.txtSiparisid.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiparisid.Location = new System.Drawing.Point(209, 8);
            this.txtSiparisid.Name = "txtSiparisid";
            this.txtSiparisid.Size = new System.Drawing.Size(156, 24);
            this.txtSiparisid.TabIndex = 13;
            // 
            // dataGridViewSiparis
            // 
            this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewSiparis.Name = "dataGridViewSiparis";
            this.dataGridViewSiparis.Size = new System.Drawing.Size(285, 150);
            this.dataGridViewSiparis.TabIndex = 0;
            // 
            // ÖdemeTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 331);
            this.Controls.Add(this.panelSiparisFaturalari);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.panelMüsteriFaturalari);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKalan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOdenen);
            this.Name = "ÖdemeTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Takip";
            this.panelMüsteriFaturalari.ResumeLayout(false);
            this.panelMüsteriFaturalari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMüsteri)).EndInit();
            this.panelSiparisFaturalari.ResumeLayout(false);
            this.panelSiparisFaturalari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMüsteriFaturalari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMüsteriİd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOdenen;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ListBox listBoxMüsteri;
        private System.Windows.Forms.DataGridView dataGridViewMüsteri;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Panel panelSiparisFaturalari;
        private System.Windows.Forms.ListBox listBoxSiparis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiparisid;
        private System.Windows.Forms.DataGridView dataGridViewSiparis;
    }
}