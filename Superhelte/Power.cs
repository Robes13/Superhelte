using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhelte
{
    /// <summary>
    /// Here I have defined that everytime there is a power, 
    /// there will be a powername, and a description of what that power does.
    /// </summary>
    internal class Power
    {
        #region Fields
        private string _powerName;
        private string _powerDescription;
        #endregion Fields

        #region Properties
        public string PowerName
        { 
            get { return _powerName; } 
            set { _powerName = value; } 
        }

        public string PowerDescription
        { 
            get { return _powerDescription; }
            set { _powerDescription = value; }
        }
        #endregion Properties
    }
}
