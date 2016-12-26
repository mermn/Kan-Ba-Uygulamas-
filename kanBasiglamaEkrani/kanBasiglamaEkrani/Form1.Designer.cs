namespace kanBasiglamaEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbil = new System.Windows.Forms.ComboBox();
            this.cbilce = new System.Windows.Forms.ComboBox();
            this.cbHastane = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kan Verebileceğiniz Hastanenin Bilgilerini Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İl :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlçe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hastane :";
            // 
            // cbil
            // 
            this.cbil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbil.FormattingEnabled = true;
            this.cbil.Location = new System.Drawing.Point(71, 32);
            this.cbil.Name = "cbil";
            this.cbil.Size = new System.Drawing.Size(344, 21);
            this.cbil.TabIndex = 4;
            this.cbil.SelectedIndexChanged += new System.EventHandler(this.cbil_SelectedIndexChanged);
            // 
            // cbilce
            // 
            this.cbilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbilce.FormattingEnabled = true;
            this.cbilce.Location = new System.Drawing.Point(71, 59);
            this.cbilce.Name = "cbilce";
            this.cbilce.Size = new System.Drawing.Size(344, 21);
            this.cbilce.TabIndex = 5;
            this.cbilce.SelectedIndexChanged += new System.EventHandler(this.cbilce_SelectedIndexChanged);
            // 
            // cbHastane
            // 
            this.cbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHastane.FormattingEnabled = true;
            this.cbHastane.Location = new System.Drawing.Point(71, 86);
            this.cbHastane.Name = "cbHastane";
            this.cbHastane.Size = new System.Drawing.Size(344, 21);
            this.cbHastane.TabIndex = 6;
            this.cbHastane.SelectedIndexChanged += new System.EventHandler(this.cbHastane_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Devam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 157);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(405, 250);
            this.webBrowser1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Haritada Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 419);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbHastane);
            this.Controls.Add(this.cbilce);
            this.Controls.Add(this.cbil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kan Bağışlama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbilce;
        private System.Windows.Forms.ComboBox cbHastane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbil;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button3;
    }
}

