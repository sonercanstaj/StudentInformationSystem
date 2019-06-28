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
    public partial class OGRENCİ : Form
    {
        public OGRENCİ()
        {
            InitializeComponent();
        }

        private void OGRENCİ_Load(object sender, EventArgs e)
        {

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


                        STUDENT QUERY = con.STUDENTS.Where(x => x.Id == id && x.PASSWORD == password).FirstOrDefault();
                        if (QUERY == null)
                            MessageBox.Show("Lütfen kullanıcı adını veya şifrenizi kontrol ediniz !");
                        else
                        {
                            GİRİS_FORM a = new GİRİS_FORM();
                            a.Show();
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
}
