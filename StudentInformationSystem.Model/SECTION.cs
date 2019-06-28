using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class SECTION
    {
        [key]
        public Int32 Id { get; set; }

        public int SECTION_PRESIDENT  { get; set; }

        public string NAME { get; set; }

        public string MORTAL_TOTAL { get; set; }
    }
}
