using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    class PublicTransportationAutopark : Autopark
    {
       public override  string GetMaxPassengers()
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
          return $"This Autopark has {counter} passengers!";
            
        }

        public override string GetNumberOfVehicles()
        {
            return $"This Autopark has {vehicles.Count} vehicles!";
        }
    }
}
