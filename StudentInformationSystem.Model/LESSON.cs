using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class LESSON
    {
        [Key]
        public Int32 Id { get; set; }
        public int PERSONEL_ID { get; set; }    

        public string LESSON_NAME { get; set; }

        public string CREDİT { get; set; }

        public string CLASS { get; set; }


    }
}
