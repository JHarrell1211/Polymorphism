using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Standard gymMember1 = new Standard(100);
            VIP gymMember2 = new VIP();

            gymMember1.Activate();
            gymMember2.Activate();

            Console.WriteLine("");

            Microwave myMicrowave = new Microwave(1000, "Samsung");
            DishWasher myDishwasher = new DishWasher(0, true);

            myMicrowave.Work();
            myDishwasher.Work();
        }
    }
}
