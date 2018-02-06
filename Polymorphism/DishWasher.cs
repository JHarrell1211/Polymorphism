using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class DishWasher : Appliance
    {
        //fields invisible

        //Properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }

        //Constructors
        public DishWasher()
        {

        }

        public DishWasher(double decibelLevel, bool hasHeatDry)
        {
            DecibelLevel = decibelLevel;
            HasHeatDry = hasHeatDry;
        }

        //Methods
        public override void Work()
        {
            Console.WriteLine("I was your dishes");
            Console.WriteLine("wash wash wash");
        }






    }
}
