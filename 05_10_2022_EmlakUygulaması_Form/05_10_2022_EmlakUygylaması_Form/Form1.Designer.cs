namespace _05_10_2022_EmlakUygylaması_Form
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
            this.secimComboBox = new System.Windows.Forms.ComboBox();
            this.keİl = new System.Windows.Forms.TextBox();
            this.kiralıkEkranGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keIsınma = new System.Windows.Forms.TextBox();
            this.keOda = new System.Windows.Forms.TextBox();
            this.keKat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keİlce = new System.Windows.Forms.TextBox();
            this.satılıkEkranGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saIsınım = new System.Windows.Forms.TextBox();
            this.saOda = new System.Windows.Forms.TextBox();
            this.saKat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saİlce = new System.Windows.Forms.TextBox();
            this.saİl = new System.Windows.Forms.TextBox();
            this.durumRaporu = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kaydet = new System.Windows.Forms.Button();
            this.kiralıkEkranGroupBox.SuspendLayout();
            this.satılıkEkranGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // secimComboBox
            // 
            this.secimComboBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secimComboBox.FormattingEnabled = true;
            this.secimComboBox.Items.AddRange(new object[] {
            "Kiralık Ev",
            "Satılık Ev"});
            this.secimComboBox.Location = new System.Drawing.Point(156, 47);
            this.secimComboBox.MaxDropDownItems = 2;
            this.secimComboBox.Name = "secimComboBox";
            this.secimComboBox.Size = new System.Drawing.Size(164, 23);
            this.secimComboBox.TabIndex = 0;
            this.secimComboBox.SelectedIndexChanged += new System.EventHandler(this.secimComboBox_SelectedIndexChanged);
            // 
            // keİl
            // 
            this.keİl.Location = new System.Drawing.Point(91, 40);
            this.keİl.Name = "keİl";
            this.keİl.Size = new System.Drawing.Size(179, 22);
            this.keİl.TabIndex = 1;
            // 
            // kiralıkEkranGroupBox
            // 
            this.kiralıkEkranGroupBox.Controls.Add(this.label5);
            this.kiralıkEkranGroupBox.Controls.Add(this.label4);
            this.kiralıkEkranGroupBox.Controls.Add(this.keIsınma);
            this.kiralıkEkranGroupBox.Controls.Add(this.keOda);
            this.kiralıkEkranGroupBox.Controls.Add(this.keKat);
            this.kiralıkEkranGroupBox.Controls.Add(this.label3);
            this.kiralıkEkranGroupBox.Controls.Add(this.label2);
            this.kiralıkEkranGroupBox.Controls.Add(this.label1);
            this.kiralıkEkranGroupBox.Controls.Add(this.keİlce);
            this.kiralıkEkranGroupBox.Controls.Add(this.keİl);
            this.kiralıkEkranGroupBox.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.kiralıkEkranGroupBox.Location = new System.Drawing.Point(156, 83);
            this.kiralıkEkranGroupBox.Name = "kiralıkEkranGroupBox";
            this.kiralıkEkranGroupBox.Size = new System.Drawing.Size(276, 206);
            this.kiralıkEkranGroupBox.TabIndex = 2;
            this.kiralıkEkranGroupBox.TabStop = false;
            this.kiralıkEkranGroupBox.Text = "Kiralık Ev";
            this.kiralıkEkranGroupBox.Visible = false;
            this.kiralıkEkranGroupBox.Enter += new System.EventHandler(this.kiraEkranGroupBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Isınma Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oda Sayısı :";
            // 
            // keIsınma
            // 
            this.keIsınma.Location = new System.Drawing.Point(91, 148);
            this.keIsınma.Name = "keIsınma";
            this.keIsınma.Size = new System.Drawing.Size(179, 22);
            this.keIsınma.TabIndex = 7;
            // 
            // keOda
            // 
            this.keOda.Location = new System.Drawing.Point(91, 121);
            this.keOda.Name = "keOda";
            this.keOda.Size = new System.Drawing.Size(179, 22);
            this.keOda.TabIndex = 6;
            // 
            // keKat
            // 
            this.keKat.Location = new System.Drawing.Point(91, 94);
            this.keKat.Name = "keKat";
            this.keKat.Size = new System.Drawing.Size(179, 22);
            this.keKat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Katı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bulunduğu İlçe :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bulunduğu İl :";
            // 
            // keİlce
            // 
            this.keİlce.Location = new System.Drawing.Point(91, 67);
            this.keİlce.Name = "keİlce";
            this.keİlce.Size = new System.Drawing.Size(179, 22);
            this.keİlce.TabIndex = 2;
            // 
            // satılıkEkranGroupBox
            // 
            this.satılıkEkranGroupBox.Controls.Add(this.label6);
            this.satılıkEkranGroupBox.Controls.Add(this.label7);
            this.satılıkEkranGroupBox.Controls.Add(this.saIsınım);
            this.satılıkEkranGroupBox.Controls.Add(this.saOda);
            this.satılıkEkranGroupBox.Controls.Add(this.saKat);
            this.satılıkEkranGroupBox.Controls.Add(this.label8);
            this.satılıkEkranGroupBox.Controls.Add(this.label9);
            this.satılıkEkranGroupBox.Controls.Add(this.label10);
            this.satılıkEkranGroupBox.Controls.Add(this.saİlce);
            this.satılıkEkranGroupBox.Controls.Add(this.saİl);
            this.satılıkEkranGroupBox.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.satılıkEkranGroupBox.Location = new System.Drawing.Point(156, 83);
            this.satılıkEkranGroupBox.Name = "satılıkEkranGroupBox";
            this.satılıkEkranGroupBox.Size = new System.Drawing.Size(276, 206);
            this.satılıkEkranGroupBox.TabIndex = 10;
            this.satılıkEkranGroupBox.TabStop = false;
            this.satılıkEkranGroupBox.Text = "Satılık Ev";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Isınma Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Oda Sayısı :";
            // 
            // saIsınım
            // 
            this.saIsınım.Location = new System.Drawing.Point(92, 148);
            this.saIsınım.Name = "saIsınım";
            this.saIsınım.Size = new System.Drawing.Size(178, 22);
            this.saIsınım.TabIndex = 7;
            // 
            // saOda
            // 
            this.saOda.Location = new System.Drawing.Point(92, 121);
            this.saOda.Name = "saOda";
            this.saOda.Size = new System.Drawing.Size(178, 22);
            this.saOda.TabIndex = 6;
            // 
            // saKat
            // 
            this.saKat.Location = new System.Drawing.Point(92, 94);
            this.saKat.Name = "saKat";
            this.saKat.Size = new System.Drawing.Size(178, 22);
            this.saKat.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Katı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Bulunduğu İlçe :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Bulunduğu İl :";
            // 
            // saİlce
            // 
            this.saİlce.Location = new System.Drawing.Point(92, 67);
            this.saİlce.Name = "saİlce";
            this.saİlce.Size = new System.Drawing.Size(178, 22);
            this.saİlce.TabIndex = 2;
            // 
            // saİl
            // 
            this.saİl.Location = new System.Drawing.Point(92, 40);
            this.saİl.Name = "saİl";
            this.saİl.Size = new System.Drawing.Size(178, 22);
            this.saİl.TabIndex = 1;
            // 
            // durumRaporu
            // 
            this.durumRaporu.BackColor = System.Drawing.SystemColors.Window;
            this.durumRaporu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.durumRaporu.Location = new System.Drawing.Point(54, 321);
            this.durumRaporu.Name = "durumRaporu";
            this.durumRaporu.Size = new System.Drawing.Size(482, 97);
            this.durumRaporu.TabIndex = 11;
            this.durumRaporu.Text = "Rapor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(156, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "Seçim Ekranı";
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydet.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.kaydet.Location = new System.Drawing.Point(248, 295);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 23);
            this.kaydet.TabIndex = 10;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.keButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(598, 420);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.durumRaporu);
            this.Controls.Add(this.satılıkEkranGroupBox);
            this.Controls.Add(this.kiralıkEkranGroupBox);
            this.Controls.Add(this.secimComboBox);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.kiralıkEkranGroupBox.ResumeLayout(false);
            this.kiralıkEkranGroupBox.PerformLayout();
            this.satılıkEkranGroupBox.ResumeLayout(false);
            this.satılıkEkranGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox secimComboBox;
        private TextBox keİl;
        private GroupBox kiralıkEkranGroupBox;
        private TextBox keİlce;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox keIsınma;
        private TextBox keOda;
        private TextBox keKat;
        private Label label3;
        private GroupBox satılıkEkranGroupBox;
        private Label label6;
        private Label label7;
        private TextBox saIsınım;
        private TextBox saOda;
        private TextBox saKat;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox saİlce;
        private TextBox saİl;
        private Label durumRaporu;
        private Button kaydet;
        private Label label12;
    }
}