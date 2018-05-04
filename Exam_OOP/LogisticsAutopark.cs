using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    class LogisticsAutopark : Autopark
    {
        public override void GetMaxCargoWeight()
        {
            double counter = 0;
            if (vehicles.Count() == 0)
            {
                counter = 0;
            }
            else
            {
                foreach (var vehicle in vehicles)
                {
                    counter += vehicle.MaximumCargoWeight;
                }
            }

            Console.WriteLine($"This Logistics Autopark has {counter} max cargo weight!");
        }

        public override void GetNumberOfVehicles()
        {
            Console.WriteLine($"This Logistics Autopark has {vehicles.Count} vehicles!");
        }
    }
}
