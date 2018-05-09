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
                throw new ArgumentException("You can not add the same vehicle to the autopark twice!");
            }
            else
            {
                vehicles.Add(vehicle);
            }
        }

        public abstract string  GetNumberOfVehicles();

        public virtual string GetMaxPassengers() {
            return "";
        }

        public virtual string GetMaxCargoWeight() {
            return "";
        }






    }
}
