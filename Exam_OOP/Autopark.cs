using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    abstract class Autopark
    {
        public List<MotorVehicle> vehicles { get; set; }

        protected Autopark()
        {
             this.vehicles = new List<MotorVehicle>();
        }

        public void AddVehicle(MotorVehicle vehicle)
        {
            if (vehicles.Count == 0)
            {

                vehicles.Add(vehicle);
            }
            else if (vehicles.Contains(vehicle))
            {
                Console.WriteLine("This vehicle is already in the autopark");
            }
            else
            {
                vehicles.Add(vehicle);
            }
        }

        public abstract void  GetNumberOfVehicles();

        public virtual void GetMaxPassengers() {
            
        }

        public virtual void GetMaxCargoWeight() {
           
        }






    }
}
