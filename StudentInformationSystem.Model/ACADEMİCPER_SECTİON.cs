using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
   public class ACADEMİCPER_SECTİON {
        [key]
        public Int32 Id { get; set; }

        public SECTION SECTION { get; set; }
        public ACADEMİC_PERSONAL GetACADEMİC_PERSONAL { get; set; }

    }
}
