﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
    public class IDENTITY_INFORMATIONS
    { 
        [key]
        public Int32 Id { get; set; }

        public STUDENT STUDENT { get; set; }

        public string IDENTITY { get; set; }

        public string COUNTRY { get; set; }

        public string NATIONALITY { get; set; }
    }
}
