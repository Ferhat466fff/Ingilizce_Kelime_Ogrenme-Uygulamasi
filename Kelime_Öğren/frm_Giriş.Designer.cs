namespace Kelime_Öğren
{
    partial class frm_Giriş
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
            this.btn_GİRİŞ_YAP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AD = new System.Windows.Forms.TextBox();
            this.txt_SIFRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_GİRİŞ_YAP
            // 
            this.btn_GİRİŞ_YAP.Location = new System.Drawing.Point(138, 137);
            this.btn_GİRİŞ_YAP.Name = "btn_GİRİŞ_YAP";
            this.btn_GİRİŞ_YAP.Size = new System.Drawing.Size(219, 38);
            this.btn_GİRİŞ_YAP.TabIndex = 0;
            this.btn_GİRİŞ_YAP.Text = "Giriş Yap";
            this.btn_GİRİŞ_YAP.UseVisualStyleBackColor = true;
            this.btn_GİRİŞ_YAP.Click += new System.EventHandler(this.btn_GİRİŞ_YAP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // txt_AD
            // 
            this.txt_AD.Location = new System.Drawing.Point(138, 33);
            this.txt_AD.Name = "txt_AD";
            this.txt_AD.Size = new System.Drawing.Size(219, 34);
            this.txt_AD.TabIndex = 2;
            // 
            // txt_SIFRE
            // 
            this.txt_SIFRE.Location = new System.Drawing.Point(138, 85);
            this.txt_SIFRE.Name = "txt_SIFRE";
            this.txt_SIFRE.Size = new System.Drawing.Size(219, 34);
            this.txt_SIFRE.TabIndex = 4;
            this.txt_SIFRE.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(407, 85);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 29);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye OL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frm_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(601, 212);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txt_SIFRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GİRİŞ_YAP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Giriş";
            this.Text = "frm_Giriş";
            this.Load += new System.EventHandler(this.frm_Giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GİRİŞ_YAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AD;
        private System.Windows.Forms.TextBox txt_SIFRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}