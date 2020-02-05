using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    
    class Car
    {
        public int passangers;
        public int contrabandAmount;
        public bool alreadyChecked = false;
        public Random genereator = new Random();

        public bool Examine(Car car)
        {
            
            Random generator = new Random();
            bool hasContraband = false;
            if (car.contrabandAmount > 0)
            {
                if (generator.Next(contrabandAmount + 1) > 0)
                { 
                hasContraband = true;
                }
            }
            car.alreadyChecked = true;
            return hasContraband;
        }

    }
}
