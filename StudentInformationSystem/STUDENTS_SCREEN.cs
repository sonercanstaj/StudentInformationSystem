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
        private void Button8_Click(object sender, EventArgs e)
        {
            using (var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;"))
            {
                var id = 1;
                var QUERY = con.STUDENTS.Where(t => t.Id == id ).FirstOrDefault();
                var x = con.STUDENTS.ToList().Select(v => new {v.SURNAME});
                List<STUDENT> list = new List<STUDENT>();
                foreach (var item in x)
                {
                    STUDENT l = new STUDENT();
                    l.NAME = item.SURNAME;
                    //l.PASSWORD = item.PASSWORD;
                   // l.START_DATE = item.START_DATE;
                    list.Add(l);
                   

                }                 
            }
       }

    }
}