using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartmeter
{
    internal class meter
    {
        public int meterserialno;
        public string model;
        public double totalreading = 0;

        public meter(int serialNo, string model)
        {
            meterserialno = serialNo;
            model = model;
        }
    }
}