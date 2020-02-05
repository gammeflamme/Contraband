using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class CleanCar: Car
    {

        public CleanCar()
        {
            passangers = genereator.Next(3) + 1;
            contrabandAmount = 0;
        }


    }
}
