using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Standard : Membership
    {
        //fields
        //invisible


        //Properties
        public int Cost { get; set; }  // creates lower case "cost" automatically

        //Constructor
        public Standard()
        {

        }

        public Standard(int cost)
        {
            Cost = cost;
        }

        //Methods using override
        public override void Activate()
        {
            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("Your standard membership has been activated");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }
        }





        }
}
