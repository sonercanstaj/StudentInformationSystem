using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    class ACADEMİC_SCHEDULE
    { 
        [key]
        public int ID { get; set; }

        public ACADEMİC_PERSONAL ACADEMİC_PERSONAL { get; set; }

        public string PERIOD { get; set; }

        public string YEAR { get; set; }

    }
}
