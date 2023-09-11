using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhelte
{
    /// <summary>
    /// I have defined what variables makes up a superhero, some of the variables I've made to 
    /// string arrays, because its more suited in some cases. For example, a superhero can have multiple powers,
    /// gears, suits and be part of more than one superhero group. 
    /// </summary>
    internal class Superhuman
    {
        #region Fields
        private string _identity;
        private Power[] _powers;
        private string[] _suit;
        private string[] _gear;
        private string[] _league;
        private string _code;
        private Superhuman _archnemesis;
        #endregion Fields

        #region Properties
        public string Identity
        {
            get { return _identity; }
            set { _identity = value; }
        }

        public Power[] Powers
        {
            get { return _powers; }
            set { _powers = value; }
        }

        public string[] Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        public string[] Gear
        {
            get { return _gear; }
            set { _gear = value; }
        }

        public string[] League
        {
            get { return _league; }
            set { _league = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public Superhuman Archnemesis
        {
            get { return _archnemesis; }
            set { _archnemesis = value; }
        }
        #endregion Properties
    }
}
