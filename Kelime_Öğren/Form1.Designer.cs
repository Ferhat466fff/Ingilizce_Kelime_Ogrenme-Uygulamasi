namespace Kelime_Öğren
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_INGILIZCE = new System.Windows.Forms.TextBox();
            this.txt_TURKCE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_SURE = new System.Windows.Forms.Label();
            this.lbl_KELIME = new System.Windows.Forms.Label();
            this.lbl_CEVAP = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // txt_INGILIZCE
            // 
            this.txt_INGILIZCE.Location = new System.Drawing.Point(111, 31);
            this.txt_INGILIZCE.Name = "txt_INGILIZCE";
            this.txt_INGILIZCE.Size = new System.Drawing.Size(278, 30);
            this.txt_INGILIZCE.TabIndex = 10;
            // 
            // txt_TURKCE
            // 
            this.txt_TURKCE.Location = new System.Drawing.Point(111, 81);
            this.txt_TURKCE.Name = "txt_TURKCE";
            this.txt_TURKCE.Size = new System.Drawing.Size(278, 30);
            this.txt_TURKCE.TabIndex = 1;
            this.txt_TURKCE.TextChanged += new System.EventHandler(this.txt_TURKCE_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Süre:";
            // 
            // lbl_SURE
            // 
            this.lbl_SURE.AutoSize = true;
            this.lbl_SURE.Location = new System.Drawing.Point(497, 36);
            this.lbl_SURE.Name = "lbl_SURE";
            this.lbl_SURE.Size = new System.Drawing.Size(34, 25);
            this.lbl_SURE.TabIndex = 7;
            this.lbl_SURE.Text = "90";
            // 
            // lbl_KELIME
            // 
            this.lbl_KELIME.AutoSize = true;
            this.lbl_KELIME.Location = new System.Drawing.Point(508, 86);
            this.lbl_KELIME.Name = "lbl_KELIME";
            this.lbl_KELIME.Size = new System.Drawing.Size(23, 25);
            this.lbl_KELIME.TabIndex = 6;
            this.lbl_KELIME.Text = "0";
            // 
            // lbl_CEVAP
            // 
            this.lbl_CEVAP.AutoSize = true;
            this.lbl_CEVAP.Location = new System.Drawing.Point(279, 120);
            this.lbl_CEVAP.Name = "lbl_CEVAP";
            this.lbl_CEVAP.Size = new System.Drawing.Size(53, 25);
            this.lbl_CEVAP.TabIndex = 8;
            this.lbl_CEVAP.Text = "label";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(634, 168);
            this.Controls.Add(this.lbl_CEVAP);
            this.Controls.Add(this.lbl_SURE);
            this.Controls.Add(this.lbl_KELIME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TURKCE);
            this.Controls.Add(this.txt_INGILIZCE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_INGILIZCE;
        private System.Windows.Forms.TextBox txt_TURKCE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_SURE;
        private System.Windows.Forms.Label lbl_KELIME;
        private System.Windows.Forms.Label lbl_CEVAP;
        private System.Windows.Forms.Timer timer1;
    }
}

