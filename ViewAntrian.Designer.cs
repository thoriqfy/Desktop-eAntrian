namespace eAntrian_Skeleton_
{
    partial class ViewAntrian
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
            this.AntrianPasienTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AntrianSaatIni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BackBTn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomer Antrian Anda:";
            // 
            // AntrianPasienTb
            // 
            this.AntrianPasienTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AntrianPasienTb.Location = new System.Drawing.Point(260, 37);
            this.AntrianPasienTb.Name = "AntrianPasienTb";
            this.AntrianPasienTb.Size = new System.Drawing.Size(132, 29);
            this.AntrianPasienTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomer Antrian Saat ini:";
            // 
            // AntrianSaatIni
            // 
            this.AntrianSaatIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AntrianSaatIni.Location = new System.Drawing.Point(260, 88);
            this.AntrianSaatIni.Name = "AntrianSaatIni";
            this.AntrianSaatIni.Size = new System.Drawing.Size(132, 29);
            this.AntrianSaatIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(53, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Antrian di Depan Anda:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox3.Location = new System.Drawing.Point(261, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 29);
            this.textBox3.TabIndex = 5;
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(19, 254);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(108, 38);
            this.btRefresh.TabIndex = 6;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // BackBTn
            // 
            this.BackBTn.Location = new System.Drawing.Point(356, 254);
            this.BackBTn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBTn.Name = "BackBTn";
            this.BackBTn.Size = new System.Drawing.Size(77, 37);
            this.BackBTn.TabIndex = 8;
            this.BackBTn.Text = "Kembali";
            this.BackBTn.UseVisualStyleBackColor = true;
            this.BackBTn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewAntrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 340);
            this.Controls.Add(this.BackBTn);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AntrianSaatIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AntrianPasienTb);
            this.Controls.Add(this.label1);
            this.Name = "ViewAntrian";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewAntrian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AntrianPasienTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AntrianSaatIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button BackBTn;
    }
}

