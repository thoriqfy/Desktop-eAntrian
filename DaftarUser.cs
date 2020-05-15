using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAntrian_Skeleton_
{
    public partial class DaftarUserForm : Form
    {
        LoginMenuForm loginMenuForm = new LoginMenuForm();
        public DaftarUserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var db=new PasienModel())
            {
                try
                {
                    int x = Convert.ToInt32(textBox3.Text);
                    var user = db.Table.SingleOrDefault(k => k.Nama == textBox1.Text);
                    var result = db.Table.SingleOrDefault(k => k.NoBPJS == textBox3.Text);
                    if (user == null)
                    {
                        if (result == null)
                        {
                            DataPasien newPasien = new DataPasien();
                            newPasien.Nama = this.textBox1.Text;
                            newPasien.Password = this.textBox2.Text;
                            newPasien.NoBPJS = this.textBox3.Text;
                            db.Table.Add(newPasien);
                            db.SaveChanges();
                            MessageBox.Show("Pendaftaran berhasil");
                            this.Close();
                            loginMenuForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No BPJS Anda sudah Terdaftar");
                        }
                    } else
                    {
                        MessageBox.Show("Username sudah dipakai orang lain");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No BPJS anda Invalid");
                    textBox3.Text = string.Empty;
                    textBox3.Focus();

                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            loginMenuForm.Show();
        }
    }
}
