using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class TerrestrialPlanet:Planet
    {
        //Create Private Instance Variables+++++++++++++++++++++++
        private bool _oxygen;

        //Create Constructor Mehotd+++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(bool oxygen, string name,
            double diameter, double mass):base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }

        //Create Public Methods++++++++++++++++++++++++++++++++++++
        public override bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Habitable()
        {
            //Implement the Habitable Method
            if (this._oxygen == true)
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
