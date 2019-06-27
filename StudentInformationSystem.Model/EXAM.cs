using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class EXAM
    {
        [key]
        public Int32 Id { get; set; }

        public string EXAM_DATE { get; set; }


        public LESSON LESSON { get; set; }

        //public SECHEDULE SECHEDULE { get; set; }

        public AKADEMİCPERSONEL PERSONEL { get; set; }
        public AKADEMİCPERSONEL PERSONELl { get; set; }


    }
}
