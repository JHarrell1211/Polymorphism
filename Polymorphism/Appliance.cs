using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public abstract class Appliance
    {
        //field
        private bool isElectric;

        //properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //Constructors - None

        //Methods
        public abstract void Work();










    }
}
