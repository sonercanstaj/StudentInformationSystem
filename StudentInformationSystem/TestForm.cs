using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInformationSystem.Model;


namespace StudentInformationSystem
{
    public partial class GİRİS_FORM : Form
    {
        public GİRİS_FORM()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //admin paneli
            int id = Convert.ToInt32(textBox1.Text);
                var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
            
            Model.STUDENT QUERY = con.STUDENTS.FirstOrDefault();
            











            //label1.Text=QUERY.NAME;

            //int idO = Convert.ToInt32(textBox1.Text);
            //var caN = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
            //Model.MORTAR QUERYE = caN.MORTARS.Where(x => x.Id == idO).SingleOrDefault();
            //label2.Text = QUERYE.TOTAL;













            //      var id = 1;
            //    using (var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;")) ;
            //    { 
            //    var QUERY = con.STUDENTS.Where(t => t.Id == id).FirstOrDefault();
            //var x = con.STUDENTS.ToList().Select(v => new { v.SURNAME });
            //List<STUDENT> list = new List<STUDENT>();
            //        foreach (var item in x)
            //        {
            //            STUDENT l = new STUDENT();
            //            l.NAME = item.SURNAME;
            //            //l.PASSWORD = item.PASSWORD;
            //            // l.START_DATE = item.START_DATE;
            //            list.Add(l);
            //        }


        }




        }
    }
   
    

    
