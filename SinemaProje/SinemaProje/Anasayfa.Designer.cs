namespace SinemaProje
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFilmAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seç = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaProjeDataSet = new SinemaProje.SinemaProjeDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBilet = new System.Windows.Forms.Button();
            this.filmlerTableAdapter = new SinemaProje.SinemaProjeDataSetTableAdapters.FilmlerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaProjeDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtFilmAdı);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(104, 94);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 34);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Film Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFilmAdı
            // 
            this.txtFilmAdı.Location = new System.Drawing.Point(104, 43);
            this.txtFilmAdı.Multiline = true;
            this.txtFilmAdı.Name = "txtFilmAdı";
            this.txtFilmAdı.Size = new System.Drawing.Size(127, 30);
            this.txtFilmAdı.TabIndex = 1;
            this.txtFilmAdı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(403, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmIdDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.Seç});
            this.dataGridView1.DataSource = this.filmlerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // filmIdDataGridViewTextBoxColumn
            // 
            this.filmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.HeaderText = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            this.filmIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            // 
            // Seç
            // 
            this.Seç.HeaderText = "Seç";
            this.Seç.Name = "Seç";
            // 
            // filmlerBindingSource
            // 
            this.filmlerBindingSource.DataMember = "Filmler";
            this.filmlerBindingSource.DataSource = this.sinemaProjeDataSet;
            // 
            // sinemaProjeDataSet
            // 
            this.sinemaProjeDataSet.DataSetName = "SinemaProjeDataSet";
            this.sinemaProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBilet);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(25, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comboboxa Göre";
            // 
            // btnBilet
            // 
            this.btnBilet.Location = new System.Drawing.Point(24, 62);
            this.btnBilet.Name = "btnBilet";
            this.btnBilet.Size = new System.Drawing.Size(171, 64);
            this.btnBilet.TabIndex = 3;
            this.btnBilet.Text = "Bilet Al";
            this.btnBilet.UseVisualStyleBackColor = true;
            this.btnBilet.Click += new System.EventHandler(this.btnBilet_Click);
            // 
            // filmlerTableAdapter
            // 
            this.filmlerTableAdapter.ClearBeforeFill = true;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaProjeDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFilmAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBilet;
        private SinemaProjeDataSet sinemaProjeDataSet;
        private System.Windows.Forms.BindingSource filmlerBindingSource;
        private SinemaProjeDataSetTableAdapters.FilmlerTableAdapter filmlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seç;
    }
}

