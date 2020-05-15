using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAntrian_Skeleton_
{
    public partial class AmbilAntrian : Form
    {
        UserMainMenu userMainMenu;
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        int interval;
        int time = 2000;
        string NoBPJS;
        public AmbilAntrian(UserMainMenu userMainMenu,string NoBPJS)
        {
            InitializeComponent();
            this.userMainMenu = userMainMenu;
            this.NoBPJS = NoBPJS;
        }



        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.userMainMenu.Show();
        }

        private void AmbilAntrian_Load(object sender, EventArgs e)
        {
            using (var db = new DokterModel())
            {
                int a = 2;
                for (int i = 1; i < a; i++)
                {
                    var newWord = db.Table.SingleOrDefault(k => k.Id == i);
                    if (newWord != null)
                    {
                        this.source.AddRange(new string[] { newWord.NamaDokter});
                        a++;
                    }
                    else
                    {
                        break;
                    }
                }
                NamaDokterTb.AutoCompleteCustomSource = this.source;
            }
        }

        private void AmbilAntrianBtn_Click(object sender, EventArgs e)
        {
            using (var Dokterdb=new DokterModel())
            {
                var Pasiendb = new PasienModel();
                var Pasien = Pasiendb.Table.SingleOrDefault(k => k.NoBPJS == NoBPJS);
                var Dokter = Dokterdb.Table.SingleOrDefault(k => k.NamaDokter == NamaDokterTb.Text);
                /*if (Pasien.SudahAntri == 0)
                {*/
                    Pasien.NoAntrian = Dokter.AntrianSaatIni + Dokter.JumlahAntrian;
                    if (Pasien.NoAntrian == 0)
                    {
                        Pasien.NoAntrian = 1;
                        Dokter.NoBPJSygDilayani = Pasien.NoBPJS;
                    }
                    Pasien.SudahAntri = 1;
                    Pasien.JanjiDgnDokter = Dokter.NamaDokter;
                    Dokter.JumlahAntrian++;
                    interval = Dokter.JumlahAntrian * time;
                    this.userMainMenu.startTimer(interval);
                    Pasiendb.SaveChanges();
                    Dokterdb.SaveChanges();
                    var result =MessageBox.Show("Apakah Anda mau Kembali", "Success",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                        this.userMainMenu.Show();
                    }
                    else
                    {
                        NamaDokterTb.Text = string.Empty;
                        SpecialisTb.Text = string.Empty;
                        JadwalTb.Text = string.Empty;
                        JumlahAntrianTb.Text = string.Empty;
                        AntrianSaatIniTb.Text = string.Empty;
                    }
                /*}
                else
                {
                    MessageBox.Show("Anda sudah memiliki Janji dengan Dokter Lain");
                }*/
            }
        }

        private void NamaDokterTb_TextChanged(object sender, EventArgs e)
        {
            AmbilAntrianBtn.Enabled = false;
            using (var db = new DokterModel())
            {
                var dokter = db.Table.SingleOrDefault(k => k.NamaDokter == NamaDokterTb.Text);
                if (dokter != null)
                {
                    SpecialisTb.Text = dokter.Spesialis;
                    JadwalTb.Text = dokter.Jadwal;
                    JumlahAntrianTb.Text = Convert.ToString(dokter.JumlahAntrian);
                    AntrianSaatIniTb.Text = Convert.ToString(dokter.AntrianSaatIni);
                    AmbilAntrianBtn.Enabled = true;
                }
            }
        }
    }
}
