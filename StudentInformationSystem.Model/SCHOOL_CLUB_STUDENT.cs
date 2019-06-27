using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class SCHOOL_CLUB_STUDENT
    {
        [key]
        public STUDENT STUDENT { get; set; }

        public SCHOOL_CLUB SCHOOL_CLUB { get; set; }

        public string NAME { get; set; }

        public string START_DATE { get; set; }

        public string FINISH_DATE { get; set; }

        public string EXPERIENCE { get; set; }
    }
}
