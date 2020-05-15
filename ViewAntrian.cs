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
    public partial class ViewAntrian : Form
    {
        UserMainMenu userMainMenu;
        string NoBPJS;
        public ViewAntrian(UserMainMenu userMainMenu,string NoBPJS)
        {
            InitializeComponent();
            this.userMainMenu = userMainMenu;
            this.NoBPJS = NoBPJS;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btRefresh_Click(object sender, EventArgs e)
        {
            ViewAntrian viewAntrian = new ViewAntrian(this.userMainMenu,this.NoBPJS);
            viewAntrian.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.userMainMenu.Show();
        }

        private void ViewAntrian_Load(object sender, EventArgs e)
        {
            using(var Pasiendb=new PasienModel())
            {
                var Dokterdb = new DokterModel();
                var Pasien = Pasiendb.Table.SingleOrDefault(k => k.NoBPJS == this.NoBPJS);
                var Dokter = Dokterdb.Table.SingleOrDefault(k => k.NamaDokter == Pasien.JanjiDgnDokter);
                if (Dokter != null)
                {
                    AntrianPasienTb.Text = Convert.ToString(Pasien.NoAntrian);
                    AntrianSaatIni.Text = Convert.ToString(Dokter.AntrianSaatIni);
                    textBox3.Text = Convert.ToString(Pasien.NoAntrian - 1);
                }
            }
        }
    }
}
