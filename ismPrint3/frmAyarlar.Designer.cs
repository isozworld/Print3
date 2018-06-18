namespace ismPrint3
{
    partial class frmAyarlar
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
            this.btnYaziciAyarlariKaydet = new System.Windows.Forms.Button();
            this.btnLoadPrinters = new System.Windows.Forms.Button();
            this.btnSilPrinter = new System.Windows.Forms.Button();
            this.cmbPrinters = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrintCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimerShutdownInterval = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSfSol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSfSag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSfUst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSfAlt = new System.Windows.Forms.TextBox();
            this.chkPrintHaderFooter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrintFileLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYaziciAyarlariKaydet);
            this.groupBox1.Controls.Add(this.btnLoadPrinters);
            this.groupBox1.Controls.Add(this.btnSilPrinter);
            this.groupBox1.Controls.Add(this.cmbPrinters);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrintCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTimerShutdownInterval);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnYaziciAyarlariKaydet
            // 
            this.btnYaziciAyarlariKaydet.Location = new System.Drawing.Point(228, 240);
            this.btnYaziciAyarlariKaydet.Name = "btnYaziciAyarlariKaydet";
            this.btnYaziciAyarlariKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnYaziciAyarlariKaydet.TabIndex = 6;
            this.btnYaziciAyarlariKaydet.Text = "Kaydet";
            this.btnYaziciAyarlariKaydet.UseVisualStyleBackColor = true;
            this.btnYaziciAyarlariKaydet.Click += new System.EventHandler(this.btnYaziciAyarlariKaydet_Click);
            // 
            // btnLoadPrinters
            // 
            this.btnLoadPrinters.Location = new System.Drawing.Point(246, 52);
            this.btnLoadPrinters.Name = "btnLoadPrinters";
            this.btnLoadPrinters.Size = new System.Drawing.Size(57, 23);
            this.btnLoadPrinters.TabIndex = 21;
            this.btnLoadPrinters.Text = "Yenile";
            this.btnLoadPrinters.UseVisualStyleBackColor = true;
            this.btnLoadPrinters.Click += new System.EventHandler(this.btnLoadPrinters_Click);
            // 
            // btnSilPrinter
            // 
            this.btnSilPrinter.Location = new System.Drawing.Point(10, 52);
            this.btnSilPrinter.Name = "btnSilPrinter";
            this.btnSilPrinter.Size = new System.Drawing.Size(57, 23);
            this.btnSilPrinter.TabIndex = 20;
            this.btnSilPrinter.Text = "Sil";
            this.btnSilPrinter.UseVisualStyleBackColor = true;
            this.btnSilPrinter.Click += new System.EventHandler(this.btnSilPrinter_Click);
            // 
            // cmbPrinters
            // 
            this.cmbPrinters.FormattingEnabled = true;
            this.cmbPrinters.Location = new System.Drawing.Point(9, 25);
            this.cmbPrinters.Name = "cmbPrinters";
            this.cmbPrinters.Size = new System.Drawing.Size(297, 21);
            this.cmbPrinters.TabIndex = 18;
            this.cmbPrinters.SelectedIndexChanged += new System.EventHandler(this.cmbPrinters_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yazdırma Sayısı";
            // 
            // txtPrintCount
            // 
            this.txtPrintCount.Location = new System.Drawing.Point(117, 112);
            this.txtPrintCount.Name = "txtPrintCount";
            this.txtPrintCount.Size = new System.Drawing.Size(54, 20);
            this.txtPrintCount.TabIndex = 7;
            this.txtPrintCount.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bekleme süresi (Ms.)";
            // 
            // txtTimerShutdownInterval
            // 
            this.txtTimerShutdownInterval.Location = new System.Drawing.Point(117, 135);
            this.txtTimerShutdownInterval.Name = "txtTimerShutdownInterval";
            this.txtTimerShutdownInterval.Size = new System.Drawing.Size(54, 20);
            this.txtTimerShutdownInterval.TabIndex = 1;
            this.txtTimerShutdownInterval.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sayfa Kenar Boşlukları";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sol";
            // 
            // txtSfSol
            // 
            this.txtSfSol.Location = new System.Drawing.Point(75, 192);
            this.txtSfSol.Name = "txtSfSol";
            this.txtSfSol.Size = new System.Drawing.Size(50, 20);
            this.txtSfSol.TabIndex = 15;
            this.txtSfSol.Text = "0.75";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sağ";
            // 
            // txtSfSag
            // 
            this.txtSfSag.Location = new System.Drawing.Point(19, 192);
            this.txtSfSag.Name = "txtSfSag";
            this.txtSfSag.Size = new System.Drawing.Size(50, 20);
            this.txtSfSag.TabIndex = 13;
            this.txtSfSag.Text = "0.75";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Üst";
            // 
            // txtSfUst
            // 
            this.txtSfUst.Location = new System.Drawing.Point(75, 147);
            this.txtSfUst.Name = "txtSfUst";
            this.txtSfUst.Size = new System.Drawing.Size(50, 20);
            this.txtSfUst.TabIndex = 11;
            this.txtSfUst.Text = "0.75";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alt";
            // 
            // txtSfAlt
            // 
            this.txtSfAlt.Location = new System.Drawing.Point(19, 147);
            this.txtSfAlt.Name = "txtSfAlt";
            this.txtSfAlt.Size = new System.Drawing.Size(50, 20);
            this.txtSfAlt.TabIndex = 9;
            this.txtSfAlt.Text = "0.75";
            // 
            // chkPrintHaderFooter
            // 
            this.chkPrintHaderFooter.AutoSize = true;
            this.chkPrintHaderFooter.Location = new System.Drawing.Point(6, 78);
            this.chkPrintHaderFooter.Name = "chkPrintHaderFooter";
            this.chkPrintHaderFooter.Size = new System.Drawing.Size(99, 17);
            this.chkPrintHaderFooter.TabIndex = 6;
            this.chkPrintHaderFooter.Text = "Başlıkları Yazdır";
            this.chkPrintHaderFooter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Printer Kaynak Url";
            // 
            // txtPrintFileLocation
            // 
            this.txtPrintFileLocation.Location = new System.Drawing.Point(6, 30);
            this.txtPrintFileLocation.Name = "txtPrintFileLocation";
            this.txtPrintFileLocation.Size = new System.Drawing.Size(246, 20);
            this.txtPrintFileLocation.TabIndex = 4;
            this.txtPrintFileLocation.Text = "http://moderona.elizabeth.com.tr:8080/App/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "KAPAT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(494, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Köseoğlu Yazılım Bölümü";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrintFileLocation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkPrintHaderFooter);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtSfAlt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSfUst);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSfSol);
            this.groupBox2.Controls.Add(this.txtSfSag);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(326, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 260);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimerShutdownInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrintFileLocation;
        private System.Windows.Forms.CheckBox chkPrintHaderFooter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrintCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSfSol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSfSag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSfUst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSfAlt;
        private System.Windows.Forms.Button btnSilPrinter;
        private System.Windows.Forms.ComboBox cmbPrinters;
        private System.Windows.Forms.Button btnLoadPrinters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYaziciAyarlariKaydet;
    }
}