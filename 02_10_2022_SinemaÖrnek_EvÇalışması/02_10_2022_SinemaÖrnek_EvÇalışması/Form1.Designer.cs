namespace _02_10_2022_SinemaÖrnek_EvÇalışması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.salonNo = new System.Windows.Forms.TextBox();
            this.koltukSayısı = new System.Windows.Forms.TextBox();
            this.olusturButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.satısIptal = new System.Windows.Forms.GroupBox();
            this.indirimSecenek = new System.Windows.Forms.CheckBox();
            this.iadeButon = new System.Windows.Forms.Button();
            this.satısButon = new System.Windows.Forms.Button();
            this.rapor = new System.Windows.Forms.GroupBox();
            this.hasılatButon = new System.Windows.Forms.Button();
            this.bosKoltukButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.koltukSayısıBar = new System.Windows.Forms.ProgressBar();
            this.durumPaneli = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hasılatDurumuBar = new System.Windows.Forms.ProgressBar();
            this.satısIptal.SuspendLayout();
            this.rapor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salonNo
            // 
            this.salonNo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salonNo.Location = new System.Drawing.Point(129, 34);
            this.salonNo.Name = "salonNo";
            this.salonNo.Size = new System.Drawing.Size(250, 22);
            this.salonNo.TabIndex = 0;
            this.salonNo.TextChanged += new System.EventHandler(this.salonNo_TextChanged);
            // 
            // koltukSayısı
            // 
            this.koltukSayısı.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.koltukSayısı.Location = new System.Drawing.Point(129, 87);
            this.koltukSayısı.Name = "koltukSayısı";
            this.koltukSayısı.Size = new System.Drawing.Size(250, 22);
            this.koltukSayısı.TabIndex = 1;
            // 
            // olusturButon
            // 
            this.olusturButon.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.olusturButon.Location = new System.Drawing.Point(442, 34);
            this.olusturButon.Name = "olusturButon";
            this.olusturButon.Size = new System.Drawing.Size(250, 76);
            this.olusturButon.TabIndex = 2;
            this.olusturButon.Text = "Oluştur";
            this.olusturButon.UseVisualStyleBackColor = true;
            this.olusturButon.Click += new System.EventHandler(this.olusturButon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(129, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koltuk Sayısı";
            // 
            // satısIptal
            // 
            this.satısIptal.Controls.Add(this.indirimSecenek);
            this.satısIptal.Controls.Add(this.iadeButon);
            this.satısIptal.Controls.Add(this.satısButon);
            this.satısIptal.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.satısIptal.Location = new System.Drawing.Point(129, 147);
            this.satısIptal.Name = "satısIptal";
            this.satısIptal.Size = new System.Drawing.Size(250, 120);
            this.satısIptal.TabIndex = 5;
            this.satısIptal.TabStop = false;
            this.satısIptal.Text = "Satış-İptal";
            // 
            // indirimSecenek
            // 
            this.indirimSecenek.AutoSize = true;
            this.indirimSecenek.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.indirimSecenek.Location = new System.Drawing.Point(6, 23);
            this.indirimSecenek.Name = "indirimSecenek";
            this.indirimSecenek.Size = new System.Drawing.Size(61, 18);
            this.indirimSecenek.TabIndex = 9;
            this.indirimSecenek.Text = "İndirim";
            this.indirimSecenek.UseVisualStyleBackColor = true;
            // 
            // iadeButon
            // 
            this.iadeButon.Font = new System.Drawing.Font("Calibri", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.iadeButon.Location = new System.Drawing.Point(6, 79);
            this.iadeButon.Name = "iadeButon";
            this.iadeButon.Size = new System.Drawing.Size(238, 21);
            this.iadeButon.TabIndex = 7;
            this.iadeButon.Text = "İade";
            this.iadeButon.UseVisualStyleBackColor = true;
            this.iadeButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // satısButon
            // 
            this.satısButon.Font = new System.Drawing.Font("Calibri", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.satısButon.Location = new System.Drawing.Point(6, 47);
            this.satısButon.Name = "satısButon";
            this.satısButon.Size = new System.Drawing.Size(238, 21);
            this.satısButon.TabIndex = 8;
            this.satısButon.Text = "Satış";
            this.satısButon.UseVisualStyleBackColor = true;
            this.satısButon.Click += new System.EventHandler(this.satısButon_Click);
            // 
            // rapor
            // 
            this.rapor.Controls.Add(this.hasılatButon);
            this.rapor.Controls.Add(this.bosKoltukButon);
            this.rapor.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.rapor.Location = new System.Drawing.Point(439, 147);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(253, 120);
            this.rapor.TabIndex = 6;
            this.rapor.TabStop = false;
            this.rapor.Text = "Rapor";
            // 
            // hasılatButon
            // 
            this.hasılatButon.Font = new System.Drawing.Font("Calibri", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.hasılatButon.Location = new System.Drawing.Point(9, 79);
            this.hasılatButon.Name = "hasılatButon";
            this.hasılatButon.Size = new System.Drawing.Size(238, 21);
            this.hasılatButon.TabIndex = 9;
            this.hasılatButon.Text = "Hasılat";
            this.hasılatButon.UseVisualStyleBackColor = true;
            this.hasılatButon.Click += new System.EventHandler(this.hasılatButon_Click);
            // 
            // bosKoltukButon
            // 
            this.bosKoltukButon.Font = new System.Drawing.Font("Calibri", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.bosKoltukButon.Location = new System.Drawing.Point(9, 47);
            this.bosKoltukButon.Name = "bosKoltukButon";
            this.bosKoltukButon.Size = new System.Drawing.Size(238, 21);
            this.bosKoltukButon.TabIndex = 10;
            this.bosKoltukButon.Text = "Boş Koltuk";
            this.bosKoltukButon.UseVisualStyleBackColor = true;
            this.bosKoltukButon.Click += new System.EventHandler(this.bosKoltukButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(129, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salon Numarası";
            // 
            // koltukSayısıBar
            // 
            this.koltukSayısıBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.koltukSayısıBar.Location = new System.Drawing.Point(104, 56);
            this.koltukSayısıBar.MarqueeAnimationSpeed = 0;
            this.koltukSayısıBar.Name = "koltukSayısıBar";
            this.koltukSayısıBar.Size = new System.Drawing.Size(453, 20);
            this.koltukSayısıBar.Step = 1;
            this.koltukSayısıBar.TabIndex = 10;
            this.koltukSayısıBar.Click += new System.EventHandler(this.koltukSayısıBar_Click);
            // 
            // durumPaneli
            // 
            this.durumPaneli.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.durumPaneli.Enabled = false;
            this.durumPaneli.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.durumPaneli.Location = new System.Drawing.Point(6, 23);
            this.durumPaneli.Name = "durumPaneli";
            this.durumPaneli.Size = new System.Drawing.Size(551, 20);
            this.durumPaneli.TabIndex = 7;
            this.durumPaneli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Koltuk Durumu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.hasılatDurumuBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.durumPaneli);
            this.groupBox1.Controls.Add(this.koltukSayısıBar);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.groupBox1.Location = new System.Drawing.Point(129, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(563, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durum Raporu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hasılat Durumu";
            // 
            // hasılatDurumuBar
            // 
            this.hasılatDurumuBar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hasılatDurumuBar.Location = new System.Drawing.Point(104, 82);
            this.hasılatDurumuBar.Name = "hasılatDurumuBar";
            this.hasılatDurumuBar.Size = new System.Drawing.Size(453, 20);
            this.hasılatDurumuBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hasılatDurumuBar.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.satısIptal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.olusturButon);
            this.Controls.Add(this.koltukSayısı);
            this.Controls.Add(this.salonNo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "Sinema";
            this.satısIptal.ResumeLayout(false);
            this.satısIptal.PerformLayout();
            this.rapor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox salonNo;
        private TextBox koltukSayısı;
        private Button olusturButon;
        private Label label2;
        private GroupBox satısIptal;
        private Button satısButon;
        private GroupBox rapor;
        private Button iadeButon;
        private Button hasılatButon;
        private Button bosKoltukButon;
        private Label label1;
        private CheckBox indirimSecenek;
        private ProgressBar koltukSayısıBar;
        private Label durumPaneli;
        private Label label3;
        internal GroupBox groupBox1;
        private Label label9;
        private ProgressBar hasılatDurumuBar;
    }
}