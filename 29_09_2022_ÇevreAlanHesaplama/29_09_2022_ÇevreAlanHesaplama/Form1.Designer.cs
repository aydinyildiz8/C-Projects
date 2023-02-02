namespace _29_09_2022_ÇevreAlanHesaplama
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
            this.radioButtonÇevre = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.radioButtonAlan = new System.Windows.Forms.RadioButton();
            this.kısaKenarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uzunKenarTextBox = new System.Windows.Forms.TextBox();
            this.hesapAlanı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonÇevre
            // 
            this.radioButtonÇevre.AutoSize = true;
            this.radioButtonÇevre.Location = new System.Drawing.Point(551, 85);
            this.radioButtonÇevre.Name = "radioButtonÇevre";
            this.radioButtonÇevre.Size = new System.Drawing.Size(94, 19);
            this.radioButtonÇevre.TabIndex = 0;
            this.radioButtonÇevre.TabStop = true;
            this.radioButtonÇevre.Text = "Çevre Hesabı";
            this.radioButtonÇevre.UseVisualStyleBackColor = true;
            this.radioButtonÇevre.UseWaitCursor = true;
            this.radioButtonÇevre.CheckedChanged += new System.EventHandler(this.radioButtonÇevre_CheckedChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(269, 171);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(251, 23);
            this.button.TabIndex = 1;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = true;
            this.button.UseWaitCursor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // radioButtonAlan
            // 
            this.radioButtonAlan.AutoSize = true;
            this.radioButtonAlan.Location = new System.Drawing.Point(551, 128);
            this.radioButtonAlan.Name = "radioButtonAlan";
            this.radioButtonAlan.Size = new System.Drawing.Size(88, 19);
            this.radioButtonAlan.TabIndex = 2;
            this.radioButtonAlan.TabStop = true;
            this.radioButtonAlan.Text = "Alan Hesabı";
            this.radioButtonAlan.UseVisualStyleBackColor = true;
            this.radioButtonAlan.UseWaitCursor = true;
            this.radioButtonAlan.CheckedChanged += new System.EventHandler(this.radioButtonAlan_CheckedChanged);
            // 
            // kısaKenarTextBox
            // 
            this.kısaKenarTextBox.Location = new System.Drawing.Point(269, 84);
            this.kısaKenarTextBox.Name = "kısaKenarTextBox";
            this.kısaKenarTextBox.Size = new System.Drawing.Size(100, 23);
            this.kısaKenarTextBox.TabIndex = 3;
            this.kısaKenarTextBox.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kısa Kenar";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uzun Kenar";
            this.label2.UseWaitCursor = true;
            // 
            // uzunKenarTextBox
            // 
            this.uzunKenarTextBox.Location = new System.Drawing.Point(269, 124);
            this.uzunKenarTextBox.Name = "uzunKenarTextBox";
            this.uzunKenarTextBox.Size = new System.Drawing.Size(100, 23);
            this.uzunKenarTextBox.TabIndex = 5;
            this.uzunKenarTextBox.UseWaitCursor = true;
            // 
            // hesapAlanı
            // 
            this.hesapAlanı.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hesapAlanı.Location = new System.Drawing.Point(375, 84);
            this.hesapAlanı.Name = "hesapAlanı";
            this.hesapAlanı.Size = new System.Drawing.Size(106, 63);
            this.hesapAlanı.TabIndex = 7;
            this.hesapAlanı.UseWaitCursor = true;
            this.hesapAlanı.Click += new System.EventHandler(this.hesapAlanı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.hesapAlanı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uzunKenarTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kısaKenarTextBox);
            this.Controls.Add(this.radioButtonAlan);
            this.Controls.Add(this.button);
            this.Controls.Add(this.radioButtonÇevre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonÇevre;
        private Button button;
        private RadioButton radioButtonAlan;
        private TextBox kısaKenarTextBox;
        private Label label1;
        private Label label2;
        private TextBox uzunKenarTextBox;
        private Label hesapAlanı;
    }
}