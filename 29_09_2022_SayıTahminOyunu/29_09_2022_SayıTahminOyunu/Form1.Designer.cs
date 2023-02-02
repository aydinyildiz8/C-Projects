namespace _29_09_2022_SayıTahminOyunu
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
            this.skorTable = new System.Windows.Forms.Label();
            this.durumTextBox = new System.Windows.Forms.TextBox();
            this.baslaButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tahminTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tahminButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skorTable
            // 
            this.skorTable.BackColor = System.Drawing.SystemColors.HighlightText;
            this.skorTable.Location = new System.Drawing.Point(264, 55);
            this.skorTable.Name = "skorTable";
            this.skorTable.Size = new System.Drawing.Size(285, 15);
            this.skorTable.TabIndex = 0;
            // 
            // durumTextBox
            // 
            this.durumTextBox.Enabled = false;
            this.durumTextBox.Location = new System.Drawing.Point(264, 93);
            this.durumTextBox.Name = "durumTextBox";
            this.durumTextBox.Size = new System.Drawing.Size(285, 23);
            this.durumTextBox.TabIndex = 1;
            // 
            // baslaButon
            // 
            this.baslaButon.Location = new System.Drawing.Point(264, 230);
            this.baslaButon.Name = "baslaButon";
            this.baslaButon.Size = new System.Drawing.Size(285, 23);
            this.baslaButon.TabIndex = 2;
            this.baslaButon.Text = "Başla";
            this.baslaButon.UseVisualStyleBackColor = true;
            this.baslaButon.Click += new System.EventHandler(this.baslaButon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Durum :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tahminTextBox
            // 
            this.tahminTextBox.Location = new System.Drawing.Point(365, 151);
            this.tahminTextBox.Name = "tahminTextBox";
            this.tahminTextBox.Size = new System.Drawing.Size(89, 23);
            this.tahminTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tahmin :";
            // 
            // tahminButon
            // 
            this.tahminButon.Location = new System.Drawing.Point(365, 180);
            this.tahminButon.Name = "tahminButon";
            this.tahminButon.Size = new System.Drawing.Size(89, 23);
            this.tahminButon.TabIndex = 6;
            this.tahminButon.Text = "Tahmin";
            this.tahminButon.UseVisualStyleBackColor = true;
            this.tahminButon.Click += new System.EventHandler(this.tahminButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Skor :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tahminButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tahminTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baslaButon);
            this.Controls.Add(this.durumTextBox);
            this.Controls.Add(this.skorTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label skorTable;
        private TextBox durumTextBox;
        private Button baslaButon;
        private Label label2;
        private TextBox tahminTextBox;
        private Label label3;
        private Button tahminButon;
        private Label label1;
    }
}