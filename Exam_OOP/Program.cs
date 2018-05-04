using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Car car = new Car();
            car.Power = -10;
            car.MaximumPassengers = -11;
            car.MaximumCargoWeight = -11;

            Van van = new Van();
            van.Power = 123;
            van.MaximumPassengers = 11;
            van.MaximumCargoWeight = 11;

            Car car2 = new Car();
            car2.Power = 1;
            car2.MaximumPassengers = 11;
            car2.MaximumCargoWeight = 11;

            Bus bus = new Bus();
            bus.Power = 13;
            bus.MaximumPassengers = 11;
            bus.MaximumCargoWeight = 11;

            PublicTransportationAutopark publicTransportationAutopark = new PublicTransportationAutopark();
            publicTransportationAutopark.AddVehicle(car);
            publicTransportationAutopark.AddVehicle(car2);
            publicTransportationAutopark.AddVehicle(car);
            publicTransportationAutopark.AddVehicle(bus);

            LogisticsAutopark logisticsautopark = new LogisticsAutopark();
            logisticsautopark.AddVehicle(car);
            logisticsautopark.AddVehicle(car2);
            logisticsautopark.AddVehicle(car);
            logisticsautopark.AddVehicle(bus);

            PublicTransportationAutopark autopark = new PublicTransportationAutopark();
            autopark.AddVehicle(car);
            autopark.AddVehicle(car2);
            autopark.AddVehicle(bus);
            autopark.AddVehicle(van);
            
            List<Autopark> parks = new List<Autopark>();
            parks.Add(logisticsautopark);
            parks.Add(autopark);
            parks.Add(publicTransportationAutopark);
            
            for (int i = 0; i < parks.Count(); i++)
            {
                Autopark park = parks[i];
                park.GetNumberOfVehicles();
                park.GetMaxPassengers();
                park.GetMaxCargoWeight();


            }
        }
    }
}
