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

        public Context(string con) : base(con)
        {

        }

        public Context()
        {

        }
    }
    
}
