using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartmeter
{
    internal class reading
    {
        public int meterserialno;
        public double units;

        public reading(int meterno, double units)
        {
            meterserialno = meterno;
            units = units;
        }
    }
}
