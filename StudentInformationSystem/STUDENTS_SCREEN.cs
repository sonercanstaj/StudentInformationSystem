using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class STUDENTS_SCREEN : Form
    {
        public STUDENTS_SCREEN()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MORTAR_SCREEN A = new MORTAR_SCREEN();
            A.Show();
        }

        private void STUDENTS_SCREEN_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            IDENTTİTY_INFORMATİON_SCREEN A = new IDENTTİTY_INFORMATİON_SCREEN();
            A.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SCHOOL_CLUB_SCREEN AC = new SCHOOL_CLUB_SCREEN();
            AC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ACADEMIC_SCHEDULE_SCREEN AS = new ACADEMIC_SCHEDULE_SCREEN();
            AS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SECTION_SCREEN SS = new SECTION_SCREEN();
            SS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EXAM_RESULT_SCREEN ER = new EXAM_RESULT_SCREEN();
            ER.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LESSON_SCREEN LS = new LESSON_SCREEN();
            LS.Show();
        }
    }
}