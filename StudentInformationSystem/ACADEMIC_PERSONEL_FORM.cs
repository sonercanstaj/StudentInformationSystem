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
    public partial class ACADEMIC_PERSONEL_FORM : Form
    {
        public ACADEMIC_PERSONEL_FORM()
        {
            InitializeComponent();
        }

        private void ACADEMIC_PERSONEL_FORM_Load(object sender, EventArgs e)
        {
            int id = ADMINSTRATOR_SCREEN.id;
            string password = ADMINSTRATOR_SCREEN.password;
            var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
            ACADEMİC_PERSONAL cek = con.ACADEMİC_PERSONALS.Where(x => x.Id == id && x.PASSWORS == password).FirstOrDefault();
            lbl_ad.Text = cek.PERSONEL_NAME;
            lbl_Soyad.Text = cek.PERSONEL_SURNAME;
            lbl_bastar.Text = cek.START_DATE;
            //g
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0://özlük
                    {

                    }
                    break;
                case 1://ogrenci bilgileri
                    {
                        int id = ADMINSTRATOR_SCREEN.id;
                        string password = ADMINSTRATOR_SCREEN.password;
                        var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
                        LESSON cekme = con.ACADEMİC_PERSONALS
                            .Join(con.LESSONS, x => x.Id, y => y.PERSONAL.Id, (x, y) => new LESSON
                            {
                                Id = y.Id,
                                LESSON_NAME = y.LESSON_NAME,
                                CLASS = y.CLASS,
                                CREDİT = y.CREDİT,
                                PERSONAL = x

                            }).Where(x => x.PERSONAL.Id == id && x.PERSONAL.PASSWORS == password).FirstOrDefault();

                        lbl.Text = cekme.LESSON_NAME;
                        lbl3.Text = cekme.CREDİT;
                        lbl4.Text = cekme.CLASS;
                    }
                    break;

                case 2://dersler
                    {
                        
                    }
                    break;
                case 3://Sınavlarrr
                    {
                        MessageBox.Show("Test4");
                    }
                    break;
                case 4://Bölüm
                    {
                        MessageBox.Show("Test4");
                    }
                    break;
                case 5://not girişi
                    {
                        MessageBox.Show("Test5");
                    }
                    break;
                case 6://akademik takvim
                    {
                        MessageBox.Show("Test6");
                    }
                    break;

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            int id = ADMINSTRATOR_SCREEN.id;
            string password = ADMINSTRATOR_SCREEN.password;
            var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
            LESSON cek = con.LESSONS.Where(x => x.PERSONAL_ID == id).FirstOrDefault();
            lbl_DersAdı.Text = cek.LESSON_NAME;
            lbl_Kredi.Text = cek.CREDİT;
            lbl_Sınıf.Text = cek.CLASS;
        }
    }
}
