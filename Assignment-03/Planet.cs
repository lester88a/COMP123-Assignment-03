﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    abstract class Planet
    {
        //Create Private Instance Variables+++++++++++++++++++++++++
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        

        //Create Public properties+++++++++++++++++++++++++
        public double Diameter
        {
            get
            {
                return this._diameter; //Read-only
            }
        }

        public double Mass
        {
            get
            {
                return this._mass; //Read-only
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount; 
            }

            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name; //Read-only
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod; 
            }

            set
            {
                this._orbitalPeriod = value; 
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }

        //Constructor Method+++++++++++++++++++++++++++++++++++++++++
        public Planet(string name,
            double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //Overridden Methods+++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            return "Name: " + this._name + ", Diameter: " + 
                this._diameter + ", Mass: " + this._mass + ".";
        }
        //public abstract string HasMoons();
        //public abstract string HasRings();
        //public abstract string Habitable();


      
    }
}
