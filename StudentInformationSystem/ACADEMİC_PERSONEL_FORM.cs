using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInformationSystem.Model;



namespace StudentInformationSystem
{
    public partial class ACADEMİC_PERSONEL_FORM : Form
    {
        public ACADEMİC_PERSONEL_FORM()
        {
            InitializeComponent();
        }
        private void GİRİS_BTN_Click(object sender, EventArgs e)
        {

            if (Kullanici_Adi_Txt != null && PASSWORD_TXT != null)
            {
                try
                {
                    using (var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;"))
                    {
                        int id = Convert.ToInt32(Kullanici_Adi_Txt.Text);
                        string password = PASSWORD_TXT.Text;
                        ACADEMİC_PERSONAL QUERY = con.ACADEMİC_PERSONALS.Where(x => x.Id == id && x.PASSWORS == password).FirstOrDefault();
                        if (QUERY == null)
                            MessageBox.Show("Lütfen kullanıcı adını veya şifrenizi kontrol ediniz !");
                        else
                        {
                            ACADEMİC_PERSONEL_SCREEN SCREEN = new ACADEMİC_PERSONEL_SCREEN();
                            SCREEN.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show("Kullanıcı adınızı kontrol ediniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adınızı boş girmeyiniz girip tekrar deneyiniz!");
            }
        }
        private void ACADEMİC_PERSONEL_FORM_Load(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                Kullanici_Adi_Txt.PasswordChar = '\0';
            }
            else
            {
                PASSWORD_TXT.PasswordChar = '*';
            }
        }
    }
    }

