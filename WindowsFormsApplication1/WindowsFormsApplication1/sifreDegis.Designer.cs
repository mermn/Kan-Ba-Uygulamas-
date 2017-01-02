namespace WindowsFormsApplication1
{
    partial class sifreDegis
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
            this.tbEskiSifre = new System.Windows.Forms.TextBox();
            this.tbYeniSifre = new System.Windows.Forms.TextBox();
            this.tbYeniSifreD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEskiSifre
            // 
            this.tbEskiSifre.Location = new System.Drawing.Point(12, 28);
            this.tbEskiSifre.Name = "tbEskiSifre";
            this.tbEskiSifre.Size = new System.Drawing.Size(134, 20);
            this.tbEskiSifre.TabIndex = 0;
            // 
            // tbYeniSifre
            // 
            this.tbYeniSifre.Location = new System.Drawing.Point(12, 67);
            this.tbYeniSifre.Name = "tbYeniSifre";
            this.tbYeniSifre.Size = new System.Drawing.Size(134, 20);
            this.tbYeniSifre.TabIndex = 1;
            // 
            // tbYeniSifreD
            // 
            this.tbYeniSifreD.Location = new System.Drawing.Point(12, 106);
            this.tbYeniSifreD.Name = "tbYeniSifreD";
            this.tbYeniSifreD.Size = new System.Drawing.Size(134, 20);
            this.tbYeniSifreD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eski Şifreniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Şifreniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Şifrenizi Doğrulayınız :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Devam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sifreDegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 169);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYeniSifreD);
            this.Controls.Add(this.tbYeniSifre);
            this.Controls.Add(this.tbEskiSifre);
            this.Name = "sifreDegis";
            this.Text = "Şifre Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEskiSifre;
        private System.Windows.Forms.TextBox tbYeniSifre;
        private System.Windows.Forms.TextBox tbYeniSifreD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}