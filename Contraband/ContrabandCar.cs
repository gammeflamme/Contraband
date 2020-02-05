using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class ContrabandCar : Car
    {

        public ContrabandCar()

        {
            passangers = genereator.Next(4) + 1;
            contrabandAmount = genereator.Next(4) + 1;
        }
    }
}
