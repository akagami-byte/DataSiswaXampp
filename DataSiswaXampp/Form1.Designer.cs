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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataBaseSiswa = new GroupBox();
            DataSiswa = new DataGridView();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            Nohp = new TextBox();
            label6 = new Label();
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
            TombolHapus = new Button();
            TombolUbah = new Button();
            TombolSimpan = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            FilterButton = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            CariData = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            DataBaseSiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataSiswa).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // DataBaseSiswa
            // 
            DataBaseSiswa.BackColor = Color.DarkKhaki;
            DataBaseSiswa.Controls.Add(DataSiswa);
            DataBaseSiswa.Location = new Point(12, 12);
            DataBaseSiswa.Name = "DataBaseSiswa";
            DataBaseSiswa.Size = new Size(1374, 383);
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
            DataSiswa.Location = new Point(6, 30);
            DataSiswa.Name = "DataSiswa";
            DataSiswa.RowHeadersWidth = 62;
            DataSiswa.ScrollBars = ScrollBars.Horizontal;
            DataSiswa.Size = new Size(1368, 340);
            DataSiswa.TabIndex = 0;
            DataSiswa.CellClick += DataSiswa_CellClick;
            DataSiswa.CellContentClick += DataSiswa_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkKhaki;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(pictureBox1);
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
            groupBox2.Location = new Point(535, 416);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(851, 279);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Isi Data";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.CornflowerBlue;
            dateTimePicker1.Location = new Point(17, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(761, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Nohp
            // 
            Nohp.Location = new Point(445, 194);
            Nohp.Name = "Nohp";
            Nohp.Size = new Size(199, 31);
            Nohp.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(356, 188);
            label6.Name = "label6";
            label6.Size = new Size(78, 24);
            label6.TabIndex = 8;
            label6.Text = "No. HP";
            // 
            // Email
            // 
            Email.Location = new Point(445, 141);
            Email.Name = "Email";
            Email.Size = new Size(199, 31);
            Email.TabIndex = 4;
            Email.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 86);
            label1.Name = "label1";
            label1.Size = new Size(57, 26);
            label1.TabIndex = 3;
            label1.Text = "NIM";
            label1.Click += label1_Click;
            // 
            // Alamat
            // 
            Alamat.Location = new Point(445, 91);
            Alamat.Name = "Alamat";
            Alamat.Size = new Size(199, 31);
            Alamat.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 194);
            label3.Name = "label3";
            label3.Size = new Size(59, 24);
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
            label5.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(356, 144);
            label5.Name = "label5";
            label5.Size = new Size(66, 24);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // Nama
            // 
            Nama.Location = new Point(117, 137);
            Nama.Name = "Nama";
            Nama.Size = new Size(202, 31);
            Nama.TabIndex = 1;
            Nama.TextChanged += NamaText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(356, 89);
            label4.Name = "label4";
            label4.Size = new Size(83, 24);
            label4.TabIndex = 6;
            label4.Text = "Alamat";
            label4.Click += label4_Click;
            // 
            // NIM
            // 
            NIM.Location = new Point(117, 86);
            NIM.Name = "NIM";
            NIM.Size = new Size(202, 31);
            NIM.TabIndex = 0;
            NIM.TextChanged += NIM_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 4;
            label2.Text = "Nama";
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkKhaki;
            groupBox3.Controls.Add(TombolHapus);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(FilterButton);
            groupBox3.Controls.Add(TombolUbah);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TombolSimpan);
            groupBox3.Controls.Add(CariData);
            groupBox3.Location = new Point(12, 416);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(508, 257);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fitur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 140);
            label8.Name = "label8";
            label8.Size = new Size(108, 24);
            label8.TabIndex = 8;
            label8.Text = "Pilih FIlter";
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(27, 211);
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
            comboBox1.Location = new Point(27, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 33);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Pilih Filter";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 46);
            label7.Name = "label7";
            label7.Size = new Size(117, 33);
            label7.TabIndex = 1;
            label7.Text = "Cari Data";
            // 
            // CariData
            // 
            CariData.Location = new Point(27, 85);
            CariData.Multiline = true;
            CariData.Name = "CariData";
            CariData.Size = new Size(210, 37);
            CariData.TabIndex = 0;
            CariData.TextChanged += CariData_TextChanged;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
