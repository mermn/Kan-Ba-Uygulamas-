namespace WindowsFormsApplication1
{
    partial class mailDogrula
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblComboBox1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresinize Gelen Şifreyi Doğrulayınız";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Devam";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(77, 143);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Doğrulama kodunu tekrar gönder!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(12, 9);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(35, 13);
            this.lblTCKimlik.TabIndex = 6;
            this.lblTCKimlik.Text = "label2";
            this.lblTCKimlik.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(53, 9);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "label3";
            this.lblMail.Visible = false;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(94, 9);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(35, 13);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "label4";
            this.lblSifre.Visible = false;
            // 
            // lblComboBox1
            // 
            this.lblComboBox1.AutoSize = true;
            this.lblComboBox1.Location = new System.Drawing.Point(135, 9);
            this.lblComboBox1.Name = "lblComboBox1";
            this.lblComboBox1.Size = new System.Drawing.Size(35, 13);
            this.lblComboBox1.TabIndex = 9;
            this.lblComboBox1.Text = "label5";
            this.lblComboBox1.Visible = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(176, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(35, 13);
            this.lblAdSoyad.TabIndex = 10;
            this.lblAdSoyad.Text = "label6";
            this.lblAdSoyad.Visible = false;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(217, 9);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(35, 13);
            this.lblTelNo.TabIndex = 11;
            this.lblTelNo.Text = "label7";
            this.lblTelNo.Visible = false;
            // 
            // mailDogrula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 173);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblComboBox1);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTCKimlik);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "mailDogrula";
            this.Text = "mailDogrula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblComboBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelNo;
    }
}