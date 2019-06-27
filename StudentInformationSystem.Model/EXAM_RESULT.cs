using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class EXAM_RESULT
    {
        [key]
        public EXAM EXAM { get; set; }

        public STUDENT STUDENT { get; set; }

        public string NOTE { get; set; }
    }
}
