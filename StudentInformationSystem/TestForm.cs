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
        private void Button2_Click(object sender, EventArgs e)
        {
            OGRENCİ a = new OGRENCİ();
            a.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ACADEMİC_PERSONEL_FORM a = new ACADEMİC_PERSONEL_FORM();
            a.Show();
            this.Hide();
        }
    }
    }
    

    
