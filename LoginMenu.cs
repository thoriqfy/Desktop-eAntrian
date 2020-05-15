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
    public partial class LoginMenuForm : Form
    {
        DaftarUserForm daftarUserForm;
        UserMainMenu userMainMenu;
        public LoginMenuForm()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            daftarUserForm = new DaftarUserForm();
            daftarUserForm.StartPosition = FormStartPosition.CenterScreen;
            daftarUserForm.Show();
            this.Hide();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login untuk admin");
            }
            else
            {
                using (var db = new PasienModel())
                {
                    var result = db.Table.SingleOrDefault(k => k.Nama == this.textBox1.Text);
                    if (result != null && result.Password == textBox2.Text)
                    {
                        userMainMenu = new UserMainMenu(this,result.NoBPJS);
                        userMainMenu.StartPosition = FormStartPosition.CenterParent;
                        userMainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password Anda Salah", "Login Gagal");
                    }
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
