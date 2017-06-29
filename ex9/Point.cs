using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Point
    {
        public Point Next { get; set; }
        public string Info { get; set; }

        public Point()
        {
            Info = "";
            Next = null;
        }
        public Point(string info)
        {
            Info = info;
        }
    }
}
