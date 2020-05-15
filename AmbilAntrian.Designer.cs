namespace eAntrian_Skeleton_
{
    partial class AmbilAntrian
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
            this.NamaDokterTb = new System.Windows.Forms.TextBox();
            this.AmbilAntrianBtn = new System.Windows.Forms.Button();
            this.SpecialisTb = new System.Windows.Forms.TextBox();
            this.JadwalTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.JumlahAntrianTb = new System.Windows.Forms.TextBox();
            this.AntrianSaatIniTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Dokter:";
            // 
            // NamaDokterTb
            // 
            this.NamaDokterTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NamaDokterTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NamaDokterTb.Location = new System.Drawing.Point(184, 65);
            this.NamaDokterTb.Name = "NamaDokterTb";
            this.NamaDokterTb.Size = new System.Drawing.Size(123, 20);
            this.NamaDokterTb.TabIndex = 1;
            this.NamaDokterTb.TextChanged += new System.EventHandler(this.NamaDokterTb_TextChanged);
            // 
            // AmbilAntrianBtn
            // 
            this.AmbilAntrianBtn.Enabled = false;
            this.AmbilAntrianBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmbilAntrianBtn.Location = new System.Drawing.Point(193, 236);
            this.AmbilAntrianBtn.Name = "AmbilAntrianBtn";
            this.AmbilAntrianBtn.Size = new System.Drawing.Size(103, 37);
            this.AmbilAntrianBtn.TabIndex = 4;
            this.AmbilAntrianBtn.Text = "Ambil Antrian";
            this.AmbilAntrianBtn.UseVisualStyleBackColor = true;
            this.AmbilAntrianBtn.Click += new System.EventHandler(this.AmbilAntrianBtn_Click);
            // 
            // SpecialisTb
            // 
            this.SpecialisTb.Enabled = false;
            this.SpecialisTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialisTb.Location = new System.Drawing.Point(184, 120);
            this.SpecialisTb.Name = "SpecialisTb";
            this.SpecialisTb.Size = new System.Drawing.Size(123, 19);
            this.SpecialisTb.TabIndex = 5;
            // 
            // JadwalTb
            // 
            this.JadwalTb.Enabled = false;
            this.JadwalTb.Location = new System.Drawing.Point(184, 145);
            this.JadwalTb.Name = "JadwalTb";
            this.JadwalTb.Size = new System.Drawing.Size(123, 20);
            this.JadwalTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Spesialis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jadwal:";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(393, 254);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 19);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Kembali";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jumlah Antrian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Antrian Saat Ini";
            // 
            // JumlahAntrianTb
            // 
            this.JumlahAntrianTb.Enabled = false;
            this.JumlahAntrianTb.Location = new System.Drawing.Point(193, 173);
            this.JumlahAntrianTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JumlahAntrianTb.Name = "JumlahAntrianTb";
            this.JumlahAntrianTb.Size = new System.Drawing.Size(76, 20);
            this.JumlahAntrianTb.TabIndex = 13;
            // 
            // AntrianSaatIniTb
            // 
            this.AntrianSaatIniTb.Enabled = false;
            this.AntrianSaatIniTb.Location = new System.Drawing.Point(193, 200);
            this.AntrianSaatIniTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AntrianSaatIniTb.Name = "AntrianSaatIniTb";
            this.AntrianSaatIniTb.Size = new System.Drawing.Size(76, 20);
            this.AntrianSaatIniTb.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cek";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AmbilAntrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AntrianSaatIniTb);
            this.Controls.Add(this.JumlahAntrianTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JadwalTb);
            this.Controls.Add(this.SpecialisTb);
            this.Controls.Add(this.AmbilAntrianBtn);
            this.Controls.Add(this.NamaDokterTb);
            this.Controls.Add(this.label1);
            this.Name = "AmbilAntrian";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AmbilAntrian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NamaDokterTb;
        private System.Windows.Forms.Button AmbilAntrianBtn;
        private System.Windows.Forms.TextBox SpecialisTb;
        private System.Windows.Forms.TextBox JadwalTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox JumlahAntrianTb;
        private System.Windows.Forms.TextBox AntrianSaatIniTb;
        private System.Windows.Forms.Button button1;
    }
}