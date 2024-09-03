namespace Film_Arsivim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_renk = new System.Windows.Forms.Button();
            this.btn_hakkımızda = new System.Windows.Forms.Button();
            this.btn_TamEkran = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_filmAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 104);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(446, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 82);
            this.label4.TabIndex = 1;
            this.label4.Text = "SİNEMA BABASI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1252, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_link);
            this.groupBox1.Controls.Add(this.txt_kategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_filmAdı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.groupBox1.Size = new System.Drawing.Size(312, 568);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Filmler";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_cikis);
            this.groupBox4.Controls.Add(this.btn_renk);
            this.groupBox4.Controls.Add(this.btn_hakkımızda);
            this.groupBox4.Controls.Add(this.btn_TamEkran);
            this.groupBox4.Location = new System.Drawing.Point(11, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 321);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(6, 172);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(279, 37);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_renk
            // 
            this.btn_renk.Location = new System.Drawing.Point(6, 129);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(279, 37);
            this.btn_renk.TabIndex = 2;
            this.btn_renk.Text = "RENK DEĞİŞTİR";
            this.btn_renk.UseVisualStyleBackColor = true;
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // btn_hakkımızda
            // 
            this.btn_hakkımızda.Location = new System.Drawing.Point(5, 86);
            this.btn_hakkımızda.Name = "btn_hakkımızda";
            this.btn_hakkımızda.Size = new System.Drawing.Size(279, 37);
            this.btn_hakkımızda.TabIndex = 2;
            this.btn_hakkımızda.Text = "HAKKIMIZDA";
            this.btn_hakkımızda.UseVisualStyleBackColor = true;
            this.btn_hakkımızda.Click += new System.EventHandler(this.btn_hakkımızda_Click);
            // 
            // btn_TamEkran
            // 
            this.btn_TamEkran.Location = new System.Drawing.Point(6, 43);
            this.btn_TamEkran.Name = "btn_TamEkran";
            this.btn_TamEkran.Size = new System.Drawing.Size(279, 37);
            this.btn_TamEkran.TabIndex = 2;
            this.btn_TamEkran.Text = "TAM EKRAN";
            this.btn_TamEkran.UseVisualStyleBackColor = true;
            this.btn_TamEkran.Click += new System.EventHandler(this.btn_TamEkran_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(116, 127);
            this.txt_link.Multiline = true;
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(186, 32);
            this.txt_link.TabIndex = 1;
            // 
            // txt_kategori
            // 
            this.txt_kategori.Location = new System.Drawing.Point(116, 89);
            this.txt_kategori.Multiline = true;
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(186, 32);
            this.txt_kategori.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Link:";
            // 
            // txt_filmAdı
            // 
            this.txt_filmAdı.Location = new System.Drawing.Point(116, 51);
            this.txt_filmAdı.Multiline = true;
            this.txt_filmAdı.Name = "txt_filmAdı";
            this.txt_filmAdı.Size = new System.Drawing.Size(186, 32);
            this.txt_filmAdı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(333, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.groupBox2.Size = new System.Drawing.Size(245, 568);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Listesi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webView21);
            this.groupBox3.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(583, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 564);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekran";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(231, 513);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(5, 27);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(794, 525);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1400, 716);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmBabası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_filmAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_renk;
        private System.Windows.Forms.Button btn_hakkımızda;
        private System.Windows.Forms.Button btn_TamEkran;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

