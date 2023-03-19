using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    internal class student
    {
        public object  rollno;

        public int Rollno { get; set; }
        public String name { get; set; }
        public String percentage { get; set; }
    }
}
