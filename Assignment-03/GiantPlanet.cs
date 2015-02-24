using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class GiantPlanet: Planet,IHasMoons,IHasRings
    {
        //Create Private Instance Variables+++++++++++++++++++++++
        private string _type;

        //Create Constructor Mehotd+++++++++++++++++++++++++++++++++
        public GiantPlanet(string type, string name1,
            double diameter1, double mass1):base (name1,diameter1,mass1)
        {
            this._type = type;
        }

        //Create Public Methods++++++++++++++++++++++++++++++++++++

        public bool HasMoons()
        {
            //if (MoonCount > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return (MoonCount > 0) ? true : false;
        }
        public bool HasRings()
        {
            if (RingCount > 0)
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
