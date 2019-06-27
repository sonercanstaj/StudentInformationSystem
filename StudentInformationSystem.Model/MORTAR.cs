using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class MORTAR
    {
        [key]
        public STUDENT STUDENT { get; set; }

        public ACADEMİC_SCHEDULE ACADEMİC_SCHEDULE { get; set; }

        public string TOTAL { get; set; }

        public string PAY_DATE { get; set; }
    }
}
