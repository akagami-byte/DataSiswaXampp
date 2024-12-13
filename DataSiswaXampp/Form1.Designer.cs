namespace DataSiswaXampp
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
            DataBaseSiswa = new GroupBox();
            DataSiswa = new DataGridView();
            groupBox2 = new GroupBox();
            TombolHapus = new Button();
            Nohp = new TextBox();
            TombolUbah = new Button();
            label6 = new Label();
            TombolSimpan = new Button();
            Email = new TextBox();
            label1 = new Label();
            Alamat = new TextBox();
            label3 = new Label();
            Kelas = new TextBox();
            label5 = new Label();
            Nama = new TextBox();
            label4 = new Label();
            NIM = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label8 = new Label();
            FilterButton = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            CariData = new TextBox();
            DataBaseSiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataSiswa).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // DataBaseSiswa
            // 
            DataBaseSiswa.BackColor = Color.DarkCyan;
            DataBaseSiswa.Controls.Add(DataSiswa);
            DataBaseSiswa.Location = new Point(12, 12);
            DataBaseSiswa.Name = "DataBaseSiswa";
            DataBaseSiswa.Size = new Size(1374, 329);
            DataBaseSiswa.TabIndex = 0;
            DataBaseSiswa.TabStop = false;
            DataBaseSiswa.Text = "DataBase Mahasiswa Telkom";
            DataBaseSiswa.Enter += DataBaseSiswa_Enter;
            // 
            // DataSiswa
            // 
            DataSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataSiswa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataSiswa.BackgroundColor = SystemColors.Control;
            DataSiswa.ColumnHeadersHeight = 34;
            DataSiswa.GridColor = SystemColors.Window;
            DataSiswa.Location = new Point(6, 24);
            DataSiswa.Name = "DataSiswa";
            DataSiswa.RowHeadersWidth = 62;
            DataSiswa.ScrollBars = ScrollBars.Horizontal;
            DataSiswa.Size = new Size(1368, 299);
            DataSiswa.TabIndex = 0;
            DataSiswa.CellClick += DataSiswa_CellClick;
            DataSiswa.CellContentClick += DataSiswa_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkCyan;
            groupBox2.Controls.Add(Nohp);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(Email);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Alamat);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Kelas);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Nama);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(NIM);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(535, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(851, 348);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Isi Data";
            // 
            // TombolHapus
            // 
            TombolHapus.Location = new Point(310, 191);
            TombolHapus.Name = "TombolHapus";
            TombolHapus.Size = new Size(178, 56);
            TombolHapus.TabIndex = 2;
            TombolHapus.Text = "Hapus";
            TombolHapus.UseVisualStyleBackColor = true;
            TombolHapus.Click += TombolHapus_Click;
            // 
            // Nohp
            // 
            Nohp.Location = new Point(556, 188);
            Nohp.Name = "Nohp";
            Nohp.Size = new Size(199, 31);
            Nohp.TabIndex = 5;
            // 
            // TombolUbah
            // 
            TombolUbah.Location = new Point(310, 128);
            TombolUbah.Name = "TombolUbah";
            TombolUbah.Size = new Size(178, 57);
            TombolUbah.TabIndex = 1;
            TombolUbah.Text = "Ubah";
            TombolUbah.UseVisualStyleBackColor = true;
            TombolUbah.Click += TombolUbah_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 188);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 8;
            label6.Text = "No. HP";
            // 
            // TombolSimpan
            // 
            TombolSimpan.Location = new Point(310, 74);
            TombolSimpan.Name = "TombolSimpan";
            TombolSimpan.Size = new Size(178, 48);
            TombolSimpan.TabIndex = 0;
            TombolSimpan.Text = "Simpan";
            TombolSimpan.UseVisualStyleBackColor = true;
            TombolSimpan.Click += TombolSimpan_Click;
            // 
            // Email
            // 
            Email.Location = new Point(556, 117);
            Email.Name = "Email";
            Email.Size = new Size(199, 31);
            Email.TabIndex = 4;
            Email.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(23, 58);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 3;
            label1.Text = "NIM";
            label1.Click += label1_Click;
            // 
            // Alamat
            // 
            Alamat.Location = new Point(556, 52);
            Alamat.Name = "Alamat";
            Alamat.Size = new Size(199, 31);
            Alamat.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 194);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 5;
            label3.Text = "Kelas";
            // 
            // Kelas
            // 
            Kelas.Location = new Point(117, 191);
            Kelas.Name = "Kelas";
            Kelas.Size = new Size(202, 31);
            Kelas.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 120);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // Nama
            // 
            Nama.Location = new Point(117, 123);
            Nama.Name = "Nama";
            Nama.Size = new Size(202, 31);
            Nama.TabIndex = 1;
            Nama.TextChanged += NamaText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 55);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 6;
            label4.Text = "Alamat";
            label4.Click += label4_Click;
            // 
            // NIM
            // 
            NIM.Location = new Point(117, 52);
            NIM.Name = "NIM";
            NIM.Size = new Size(202, 31);
            NIM.TabIndex = 0;
            NIM.TextChanged += NIM_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 126);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Nama";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Teal;
            groupBox3.Controls.Add(TombolHapus);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(FilterButton);
            groupBox3.Controls.Add(TombolUbah);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TombolSimpan);
            groupBox3.Controls.Add(CariData);
            groupBox3.Location = new Point(12, 347);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(508, 326);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fitur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Teal;
            label8.Location = new Point(27, 160);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 8;
            label8.Text = "Pilih FIlter";
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(27, 238);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(112, 34);
            FilterButton.TabIndex = 6;
            FilterButton.Text = "Filter";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 33);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Pilih Filter";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 46);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 1;
            label7.Text = "Cari Data";
            // 
            // CariData
            // 
            CariData.Location = new Point(27, 74);
            CariData.Multiline = true;
            CariData.Name = "CariData";
            CariData.Size = new Size(210, 37);
            CariData.TabIndex = 0;
            CariData.TextChanged += CariData_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1385, 670);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(DataBaseSiswa);
            Name = "Form1";
            Text = "Data Siswa";
            Load += Form1_Load;
            DataBaseSiswa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataSiswa).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DataBaseSiswa;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox Nohp;
        private TextBox Email;
        private TextBox Alamat;
        private TextBox Kelas;
        private TextBox Nama;
        private TextBox NIM;
        private Label label7;
        private TextBox CariData;
        private DataGridView DataSiswa;
        private Button TombolHapus;
        private Button TombolUbah;
        private Button TombolSimpan;
        private ComboBox comboBox1;
        private Button FilterButton;
        private Label label8;
    }
}
