namespace Kelime_Öğren
{
    partial class frm_UYE_OL
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
            this.txt_SIFRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UYE_OL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_SIFRE
            // 
            this.txt_SIFRE.Location = new System.Drawing.Point(103, 106);
            this.txt_SIFRE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_SIFRE.Name = "txt_SIFRE";
            this.txt_SIFRE.Size = new System.Drawing.Size(196, 38);
            this.txt_SIFRE.TabIndex = 10;
            this.txt_SIFRE.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // txt_AD
            // 
            this.txt_AD.Location = new System.Drawing.Point(103, 39);
            this.txt_AD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AD.Name = "txt_AD";
            this.txt_AD.Size = new System.Drawing.Size(196, 38);
            this.txt_AD.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad:";
            // 
            // btn_UYE_OL
            // 
            this.btn_UYE_OL.Location = new System.Drawing.Point(103, 168);
            this.btn_UYE_OL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_UYE_OL.Name = "btn_UYE_OL";
            this.btn_UYE_OL.Size = new System.Drawing.Size(196, 39);
            this.btn_UYE_OL.TabIndex = 6;
            this.btn_UYE_OL.Text = "Üye OL";
            this.btn_UYE_OL.UseVisualStyleBackColor = true;
            this.btn_UYE_OL.Click += new System.EventHandler(this.btn_GİRİŞ_YAP_Click);
            // 
            // frm_UYE_OL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 274);
            this.Controls.Add(this.txt_SIFRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UYE_OL);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_UYE_OL";
            this.Text = "frm_UYE_OL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_SIFRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_UYE_OL;
    }
}