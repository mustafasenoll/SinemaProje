namespace SinemaProje
{
    partial class BiletDetay
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
            this.lblKoltuk = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnBilet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı :";
            // 
            // lblKoltuk
            // 
            this.lblKoltuk.AutoSize = true;
            this.lblKoltuk.Location = new System.Drawing.Point(147, 65);
            this.lblKoltuk.Name = "lblKoltuk";
            this.lblKoltuk.Size = new System.Drawing.Size(59, 20);
            this.lblKoltuk.TabIndex = 3;
            this.lblKoltuk.Text = "Koltuk";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(147, 103);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(42, 20);
            this.lblFilm.TabIndex = 4;
            this.lblFilm.Text = "Film";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(97, 132);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(131, 34);
            this.txtAd.TabIndex = 5;
            // 
            // btnBilet
            // 
            this.btnBilet.Location = new System.Drawing.Point(97, 188);
            this.btnBilet.Name = "btnBilet";
            this.btnBilet.Size = new System.Drawing.Size(129, 34);
            this.btnBilet.TabIndex = 6;
            this.btnBilet.Text = "Bilet Al";
            this.btnBilet.UseVisualStyleBackColor = true;
            this.btnBilet.Click += new System.EventHandler(this.btnBilet_Click);
            // 
            // BiletDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 383);
            this.Controls.Add(this.btnBilet);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.lblKoltuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BiletDetay";
            this.Text = "BiletDetay";
            this.Load += new System.EventHandler(this.BiletDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKoltuk;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnBilet;
    }
}