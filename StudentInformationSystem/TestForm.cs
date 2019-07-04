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
            //////admin paneli
            ////int id = Convert.ToInt32(textBox1.Text);
            ////    var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");

            ////// Model.STUDENT QUERY = con.STUDENTS.Where(s => s.Id == 1&& id>=1).FirstOrDefault();
            ////var ogr_list = con.STUDENTS.ToList();
            ////dataGridView1.DataSource = ogr_list;
            var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
            var cek = con.STUDENTS.Where(a => a.START_DATE == "02.03.2018").ToList();
            dataGridView1.DataSource = cek;
            


        }

        private void GİRİS_FORM_Load(object sender, EventArgs e)
        {
            var con = new Model.Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;");
            var soner = con.STUDENTS.Count();
            MessageBox.Show(" ");
        }
        
    }
    }
   
    

    
