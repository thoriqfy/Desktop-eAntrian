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
    public partial class UserMainMenu : Form
    {
        LoginMenuForm loginMenuForm;
        ViewAntrian viewAntrian;
        AmbilAntrian ambilAntrian;
        string NoBPJS;
        public UserMainMenu(LoginMenuForm loginMenuForm,string NoBPJS)
        {
            InitializeComponent();
            this.loginMenuForm = loginMenuForm;
            this.NoBPJS = NoBPJS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewAntrian = new ViewAntrian(this,this.NoBPJS);
            viewAntrian.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginMenuForm.Close();
        }

        private void btnAmbil_Click(object sender, EventArgs e)
        {
            ambilAntrian = new AmbilAntrian(this,this.NoBPJS);
            ambilAntrian.StartPosition = FormStartPosition.CenterParent;
            ambilAntrian.Show();
            this.Hide();
        }

        public void startTimer(int time)
        {
            timer1.Interval = time;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Giliran Anda dalam x menit");
        }
    }
}
