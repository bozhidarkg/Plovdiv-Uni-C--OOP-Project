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
                    throw new ArgumentException($"{nameof(Power)} must be more than 0");
                    
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

                    throw new ArgumentException($"{nameof(MaximumPassengers)} must be more than 0");

                   
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
                    throw new ArgumentException($"{nameof(MaximumCargoWeight)} must be more than 0");
                    
                }
                else
                {
                    this.maximumCargoWeight = value;
                }
            }
        }

    }
}
