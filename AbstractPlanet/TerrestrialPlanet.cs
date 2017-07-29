using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: LF
 * Date: July 28, 2017
 * Description: This is the TerrestrialPlanet class.
 * It inherits from Planet, IHasMoons, IHabitable
 * Version: 0.1 - Create TerrestrialPlanet class.
 */
namespace AbstractPlanet
{
    public class TerrestrialPlanet: Planet, IHasMoons, IHabitable
    {
        //Private instance variable
        private bool _oxygen;
        /// <summary>
        /// return a bool value
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// return a bool value
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
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
        //constructor
        /// <summary>
        /// this is the constructor for TerrestrialPlanet.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }
    }
}