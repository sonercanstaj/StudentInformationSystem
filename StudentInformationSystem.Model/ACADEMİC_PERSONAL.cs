using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class ACADEMİC_PERSONAL
    {
        [key]
        public Int32 PERSONEL_ID { get; set; }

        public string PASSWORS { get; set; }

        public string PERSONEL_NAME { get; set; }

        public string PERSONEL_SURNAME { get; set; }

        public string START_DATE { get; set; }

        public string PENSİON_DATE { get; set; }
    }
}
