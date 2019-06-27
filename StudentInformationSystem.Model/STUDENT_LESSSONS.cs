using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    class STUDENT_LESSSONS
    {
        [key]
        public LESSON LESSON {get; set; }
        public STUDENT STUDENT { get; set; }
        public ACADEMİC_SCHEDULE ACADEMİC_SCHEDULE { get; set; }
        public string ISPASSED { get; set; }

    }
}
