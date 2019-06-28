using StudentInformationSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using (var con = new Context("Server=.;Database=STUDENT_INFORMATION_SYSTEM;Trusted_Connection=True;"))
                {
                    if (!con.Database.Exists())
                        con.Database.Create();
                    ////STUDENT sTUDENT = con.STUDENTS.Where(x => x.Id == 1).FirstOrDefault();
                    ////sTUDENT.NAME = "can";
                    ////sTUDENT.SURNAME = "Soner";
                    ////sTUDENT.PASSWORD = "";
                    
                    ////con.STUDENTS.Add(sTUDENT);

                    ////con.SaveChanges();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GİRİS_FORM());
        }
    }
}
