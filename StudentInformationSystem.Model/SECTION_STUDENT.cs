using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class SECTION_STUDENT
    {
        
        public Int32 Id { get; set; }
        [key]  
        public SECTION SECTION { get; set; }

        public STUDENT STUDENT { get; set; }

    }
}
