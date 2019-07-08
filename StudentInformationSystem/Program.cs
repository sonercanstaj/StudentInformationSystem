using StudentInformationSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
                using (var con = new Context())
                {
                    if (!con.Database.Exists())
                        con.Database.Create();
                    STUDENT sTUDENT = con.STUDENTS.Where(x => x.Id == 1).FirstOrDefault();
                   sTUDENT.NAME = "can";
                    sTUDENT.SURNAME = "Soner";
                  sTUDENT.PASSWORD = "asdasd";

                      con.STUDENTS.Add(sTUDENT);
                    con.SaveChanges();


                } }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
    
         
    
        }
    }
}
