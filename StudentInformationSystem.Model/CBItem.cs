using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Model
{
  public   class CBItem
    {
        public Int32 value;
        public string text;
        public override string ToString()
        {
            return text.ToString();
        }
    }
}
