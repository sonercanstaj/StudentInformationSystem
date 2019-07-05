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
                    
                    else
                    {
                        DbMigrator migrator = new DbMigrator(new StudentInformationSystem.Model.Migrations.Configuration());
                        migrator.Update();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
                Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new ADMINSTRATOR_SCREEN());
        }
    }
}
