namespace veritabanıProje
{
    partial class SiparisTakip
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
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.grpBoxKitap = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.grpBoxSiparis = new System.Windows.Forms.GroupBox();
            this.txtMüsteriİd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerSiparisTakip = new System.Windows.Forms.DateTimePicker();
            this.txtSiparisid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.grpBoxKitap.SuspendLayout();
            this.grpBoxSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(129, 253);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 31);
            this.btnİptal.TabIndex = 9;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(48, 253);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 31);
            this.btnOnayla.TabIndex = 8;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // grpBoxKitap
            // 
            this.grpBoxKitap.Controls.Add(this.radioButton3);
            this.grpBoxKitap.Controls.Add(this.radioButton2);
            this.grpBoxKitap.Controls.Add(this.radioButton1);
            this.grpBoxKitap.Controls.Add(this.label5);
            this.grpBoxKitap.Controls.Add(this.label4);
            this.grpBoxKitap.Controls.Add(this.label3);
            this.grpBoxKitap.Controls.Add(this.txtMiktar);
            this.grpBoxKitap.Controls.Add(this.txtAd);
            this.grpBoxKitap.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxKitap.Location = new System.Drawing.Point(24, 133);
            this.grpBoxKitap.Name = "grpBoxKitap";
            this.grpBoxKitap.Size = new System.Drawing.Size(278, 114);
            this.grpBoxKitap.TabIndex = 13;
            this.grpBoxKitap.TabStop = false;
            this.grpBoxKitap.Text = "Kitap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Miktar : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ad : ";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(107, 51);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(156, 26);
            this.txtMiktar.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(107, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(156, 26);
            this.txtAd.TabIndex = 3;
            // 
            // grpBoxSiparis
            // 
            this.grpBoxSiparis.Controls.Add(this.txtMüsteriİd);
            this.grpBoxSiparis.Controls.Add(this.label1);
            this.grpBoxSiparis.Controls.Add(this.dateTimePickerSiparisTakip);
            this.grpBoxSiparis.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxSiparis.Location = new System.Drawing.Point(24, 32);
            this.grpBoxSiparis.Name = "grpBoxSiparis";
            this.grpBoxSiparis.Size = new System.Drawing.Size(278, 97);
            this.grpBoxSiparis.TabIndex = 12;
            this.grpBoxSiparis.TabStop = false;
            // 
            // txtMüsteriİd
            // 
            this.txtMüsteriİd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMüsteriİd.Location = new System.Drawing.Point(105, 64);
            this.txtMüsteriİd.Name = "txtMüsteriİd";
            this.txtMüsteriİd.Size = new System.Drawing.Size(156, 26);
            this.txtMüsteriİd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri ID : ";
            // 
            // dateTimePickerSiparisTakip
            // 
            this.dateTimePickerSiparisTakip.Location = new System.Drawing.Point(16, 25);
            this.dateTimePickerSiparisTakip.Name = "dateTimePickerSiparisTakip";
            this.dateTimePickerSiparisTakip.Size = new System.Drawing.Size(245, 26);
            this.dateTimePickerSiparisTakip.TabIndex = 1;
            // 
            // txtSiparisid
            // 
            this.txtSiparisid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiparisid.Location = new System.Drawing.Point(129, 8);
            this.txtSiparisid.Name = "txtSiparisid";
            this.txtSiparisid.Size = new System.Drawing.Size(156, 26);
            this.txtSiparisid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sipariş ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Depo : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 83);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 22);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "d1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 22);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "d2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(199, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 22);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "d3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisSil.Location = new System.Drawing.Point(210, 253);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(75, 31);
            this.btnSiparisSil.TabIndex = 10;
            this.btnSiparisSil.Text = "Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = true;
            // 
            // SiparisTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 288);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.txtSiparisid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.grpBoxKitap);
            this.Controls.Add(this.grpBoxSiparis);
            this.Name = "SiparisTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Takip";
            this.grpBoxKitap.ResumeLayout(false);
            this.grpBoxKitap.PerformLayout();
            this.grpBoxSiparis.ResumeLayout(false);
            this.grpBoxSiparis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.GroupBox grpBoxKitap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox grpBoxSiparis;
        private System.Windows.Forms.TextBox txtMüsteriİd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSiparisTakip;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSiparisid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisSil;
    }
}