using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: LF
 * Date: July 28, 2017
 * Description: This is the GiantPlanet class.
 * It inherits from Planet, IHasMoons, IHasRings
 * Version: 0.1 - Create GiantPlanet class.
 */
namespace AbstractPlanet
{
    public class GiantPlanet: Planet, IHasMoons, IHasRings
    {
        //private instance variable
        private string _type;
        //constructor
        /// <summary>
        /// this is the constructor for GiantPlanet class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }
        /// <summary>
        /// Return a bool value
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            if(MoonCount>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Return a bool value
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            if(RingCount>0)
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