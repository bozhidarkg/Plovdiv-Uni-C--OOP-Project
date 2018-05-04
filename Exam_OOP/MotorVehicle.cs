using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
       abstract class  MotorVehicle
    {
        private int power;
        private int maximumPassengers;
        private double maximumCargoWeight;
        

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Power must be larger than 0!");
                    this.power = 100;
                }
                else
                {
                    this.power = value;
                }
            }

        }
        public  int MaximumPassengers
        {
            get
            {
                return this.maximumPassengers;
            }
             set {
                if (value <= 0)
                {
                    Console.WriteLine("Maximum passengers must be more than 0!");
                    this.maximumPassengers = 5;
                }
                else
                {
                    this.maximumPassengers = value;
                }
            }
        }

        public  double MaximumCargoWeight
        {
            get
            {
                return this.maximumCargoWeight;
            }
             set {
                if (value <= 0)
                {
                    Console.WriteLine("Maximum cargo weight must be more than 0!");
                    this.maximumCargoWeight = 200.22;
                }
                else
                {
                    this.maximumCargoWeight = value;
                }
            }
        }

    }
}
