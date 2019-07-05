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
    public partial class ADMINSTRATOR_SCREEN : Form
    {
        public ADMINSTRATOR_SCREEN()
        {
            InitializeComponent();
        }
        public static int id = 0;
        public static string password;
        private void ADMINSTRATOR_SCREEN_Load(object sender, EventArgs e)
        {
            PASSWORD_TXT.PasswordChar = '*';
        }
        private void GİRİS_BTN_Click(object sender, EventArgs e)
        {          
            if (!CHCOX_ACADEMİC.Checked)//OGR
            {

                if (Kullanici_Adi_Txt != null && PASSWORD_TXT != null)
                {
                    try
                    {
                        using (var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;"))
                        {
                            id = Convert.ToInt32(Kullanici_Adi_Txt.Text);
                            password = PASSWORD_TXT.Text;
                            STUDENT QUERY = con.STUDENTS.Where(x => x.Id == id && x.PASSWORD == password).FirstOrDefault();
                            if (QUERY == null)
                                MessageBox.Show("Lütfen kullanıcı adını veya şifrenizi kontrol ediniz !");
                            else
                            {
                                STUDENTS_SCREEN SCREEN = new STUDENTS_SCREEN();
                                SCREEN.Show();
                                this.Hide();
                            }
                        }
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show("Lütfen kullanıcı adınızı kontrol ediniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı boş girmeyiniz girip tekrar deneyiniz!");
                }
            }
            else//HOCA
            {
                if (Kullanici_Adi_Txt != null && PASSWORD_TXT != null)
                {
                    try
                    {
                        using (var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;"))
                        {
                            id = Convert.ToInt32(Kullanici_Adi_Txt.Text);
                            password = PASSWORD_TXT.Text;
                            ACADEMİC_PERSONAL QUERY = con.ACADEMİC_PERSONALS.Where(x => x.Id == id && x.PASSWORS == password).FirstOrDefault();

                            if (QUERY == null)
                                MessageBox.Show("Lütfen kullanıcı adını veya şifrenizi kontrol ediniz !");
                            else
                            {
                                ACADEMIC_PERSONEL_FORM A = new ACADEMIC_PERSONEL_FORM();
                                A.Show();

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


        }
        private void BTN_CIKIS_Click_1(object sender, EventArgs e)
        {
            this.Close();
                }

        private void ADMINSTRATOR_SCREEN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kullanici_Adi_Txt_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
