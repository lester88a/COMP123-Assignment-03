using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class GiantPlanet
    {
        //Create Private Instance Variables+++++++++++++++++++++++
        private string _type;

        //Create Constructor Mehotd+++++++++++++++++++++++++++++++++
        public GiantPlanet(string type, string name,
            double diameter, double mass)
        {
            this._type = type;
        }

        //Create Public Methods++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            //Implement the HasMoons Method
            Planet IHasMoons =new Planet("Mars", 100, 10);
            
            //If MoonCount >0, return true
            if (IHasMoons.MoonCount>0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool HasRings()
        {
            //Implement the HasRings Method
            Planet IHasRings = new Planet("Saturn", 1000, 100);

            //If RingCount >0, return true
            if (IHasRings.RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
