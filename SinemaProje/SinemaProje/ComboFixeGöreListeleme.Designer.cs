namespace SinemaProje
{
    partial class ComboFixeGöreListeleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaProjeDataSet1 = new SinemaProje.SinemaProjeDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filmlerTableAdapter = new SinemaProje.SinemaProjeDataSet1TableAdapters.FilmlerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaProjeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.filmlerBindingSource;
            this.comboBox1.DisplayMember = "FilmAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "FilmAd";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filmlerBindingSource
            // 
            this.filmlerBindingSource.DataMember = "Filmler";
            this.filmlerBindingSource.DataSource = this.sinemaProjeDataSet1;
            // 
            // sinemaProjeDataSet1
            // 
            this.sinemaProjeDataSet1.DataSetName = "SinemaProjeDataSet1";
            this.sinemaProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı :";
            // 
            // flp1
            // 
            this.flp1.Location = new System.Drawing.Point(42, 148);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(766, 520);
            this.flp1.TabIndex = 1;
            this.flp1.Paint += new System.Windows.Forms.PaintEventHandler(this.flp1_Paint);
            // 
            // filmlerTableAdapter
            // 
            this.filmlerTableAdapter.ClearBeforeFill = true;
            // 
            // ComboFixeGöreListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 692);
            this.Controls.Add(this.flp1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ComboFixeGöreListeleme";
            this.Text = "ComboFixeGöreListeleme";
            this.Load += new System.EventHandler(this.ComboFixeGöreListeleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaProjeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private SinemaProjeDataSet1 sinemaProjeDataSet1;
        private System.Windows.Forms.BindingSource filmlerBindingSource;
        private SinemaProjeDataSet1TableAdapters.FilmlerTableAdapter filmlerTableAdapter;
    }
}