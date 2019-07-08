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
    public partial class STUDENTS_SCREEN : Form
    {
        public STUDENTS_SCREEN()
        {
            InitializeComponent();
        }
        private void STUDENTS_SCREEN_Load(object sender, EventArgs e)
        {
            int id = ADMINSTRATOR_SCREEN.id;
            var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");

            Model.STUDENT QUERY = con.STUDENTS.Where(x => x.Id == id).SingleOrDefault();
            lbName.Text = QUERY.NAME;
            lbSurname.Text = QUERY.SURNAME;
            Label_Start_Date.Text = QUERY.START_DATE;
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl1.SelectedIndex)
            {
                case 0://identity informations
                    {                 

                  }
                    break;
                case 1://mortar
                    {
                        int id = ADMINSTRATOR_SCREEN.id;
                        var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
                        MORTAR ac = con.MORTARS.Where(x => x.STUDENT.Id == id).FirstOrDefault();
                        Lbl_Pay_Date.Text = ac.PAY_DATE;
                        Lbl_total.Text = ac.TOTAL;
                    }
                    break;

                case 2://school clubs
                    {
                        var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
                        
                        //  var cek = con.SCHOOL_CLUB_STUDENTS.Where(x=>x.NAME==)
                        var ComboItems  =con.SCHOOL_CLUBS.Select(x => new  CBItem { value = x.Id,text =  x.NAME }).ToList();

                        comboBox1.DataSource = ComboItems;

                        //var a = con.SCHOOL_CLUBS.ToList();




                    }
                    break;
                case 3://academic schedule
                    {
                        MessageBox.Show("Test4");
                    }
                    break;
                case 4://section
                    {
                        MessageBox.Show("Test4");
                    }
                    break;
                case 5://exam result
                    {
                    MessageBox.Show("Test5");
                    }
                    break;
                case 6://lessons
                    {
                        MessageBox.Show("Test6");
                    }
                    break;
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comboBox1.SelectedValue.ToString();
            string text = comboBox1.SelectedText;
            MessageBox.Show(value + " " + text);
        }
    }
}