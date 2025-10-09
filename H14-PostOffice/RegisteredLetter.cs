using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H14_PostOffice
{
    internal class RegisteredLetter
    {
		private double distance;
		public double Distance
		{
			get { return distance; }
			set 
			{  
				if (value > 0)
				{
                    distance = value;
                }
			}
		}

	}
}
