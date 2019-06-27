using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    class MORTAR
    {
        public STUDENT STUDENT{ get; set; }
        public ACADEMİC_SCHEDULE CADEMİC_SCHEDULE { get; set; }
        public string TOTAL { get; set; }
        public DateTime PAY_DATE { get; set; }
    }
}
