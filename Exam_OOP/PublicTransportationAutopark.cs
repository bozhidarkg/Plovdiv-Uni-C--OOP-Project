using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    class PublicTransportationAutopark : Autopark
    {
       public override  void GetMaxPassengers()
        {
            int counter = 0;
            if (vehicles.Count()==0)
            {
                counter = 0;
            }
            else
            {
                foreach (var vehicle in vehicles)
                {
                    counter += vehicle.MaximumPassengers;
                }
            }
            Console.WriteLine($"This Public Transportation Autopark has {counter} passengers!");
            
        }

        public override void GetNumberOfVehicles()
        {
            Console.WriteLine($"This Public Transportation Autopark has {vehicles.Count} vehicles!");
        }
    }
}
