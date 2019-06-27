using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class Context : DbContext
    {
        public DbSet<STUDENT> STUDENTS { get; set; }

        public DbSet<LESSON> LESSONS { get; set; }

        public DbSet<EXAM> EXAMS { get; set; }

        public DbSet<EXAM_RESULT> EXAM_RESULTS { get; set; }

        public DbSet<SECTION> SECTIONS { get; set; }

        public DbSet<SECTION_STUDENT> SECTION_STUDENTS { get; set; }

        public DbSet<SCHOOL_CLUB> SCHOOL_CLUBS { get; set; }

        public DbSet<SCHOOL_CLUB_STUDENT> SCHOOL_CLUB_STUDENTS { get; set; }

        public DbSet<IDENTITY_INFORMATIONS> IDENTITY_INFORMATIONS { get; set; }

        public DbSet<ACADEMİC_SCHEDULE> ACADEMİC_SCHEDULES { get; set; }

        public DbSet<MORTAR> MORTARS { get; set; }

        public DbSet<STUDENT_LESSSONS> STUDENT_LESSSONS { get; set; }

        public DbSet<ACADEMİC_PERSONAL> ACADEMİC_PERSONALS { get; set; }

        public DbSet<ACADEMİCPER_SECTİON> ACADEMİCPER_SECTİONS { get; set; }

        public Context(string con) : base(con)
        {

        }

        public Context()
        {

        }
    }
    
}
