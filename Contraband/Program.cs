using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            int carAmount = 0;
            Random generator = new Random();
            List<Car> cars = new List<Car>();
            Console.WriteLine("Hur många bilar ska skapas?");
            while(!int.TryParse(Console.ReadLine(), out carAmount) || carAmount <= 0)
            {
                Console.WriteLine("vänligen skriv bara naturliga tal över 0.");
            }
            for (int i = 0; i < carAmount; i++)
            {
                bool clean = 0 < generator.Next(2);
                if (clean)
                {
                    cars.Add(new CleanCar());
                }
                else
                {
                    cars.Add(new ContrabandCar());
                }

            }
            bool keepGoing = true;

            while (keepGoing == true)
            {
                int lookingAtCar;
                Console.WriteLine("vilken bil vill du titta på");
                while ((!int.TryParse(Console.ReadLine(), out lookingAtCar)) || lookingAtCar <= 0 ||  (lookingAtCar>cars.Count) )
                {
                    Console.WriteLine("vänligen skriv bara naturliga tal över 0 och inte över " + cars.Count+".");
                }
                if (cars[lookingAtCar-1].alreadyChecked)
                {
                    Console.WriteLine("Du har redan undersökt denna bil.");
                }
                else
                {
                    Console.WriteLine("Bilen har " + cars[lookingAtCar-1].contrabandAmount + " olagliga object.");
                }
                
            }



        }
    }
}
