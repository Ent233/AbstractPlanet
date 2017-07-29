using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: LF
 * Date: July 28, 2017
 * Description: This is the supper abstract Planet class.
 * Version: 0.1 - Create abstract Planet class.
 */
namespace AbstractPlanet
{
    public abstract class Planet
    {
        //private instance variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        //public properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
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
                return this._name;
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
        //constructors
        /// <summary>
        /// This is the main constructor for Planet class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name,double diameter,double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        public override string ToString()
        {
            return string.Format("The planet name is: {0}, the diameter is: {1}, the mass is: {2}",Name,Diameter,Mass);
        }
    }
}