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
		public virtual double Distance
		{
			get { return distance; }
			set 
			{  
				if (value > 0)
				{
                    distance = value;
                }
				else
				{
                    Console.WriteLine("Waarde moet groter zijn dan 0.");
				}
			}
		}

		private byte? duration;
		public virtual byte? Duration
        {
			get 
			{
				return (byte)Math.Ceiling(distance/100); 
			}
			
		}

		private double price;
		public virtual double Price
		{
			get 
			{
                if (distance < 100)
                {
                    price = 15;
                }
                else
                {
					double extra = Math.Ceiling((distance - 100) / 100);
					price = 15 + extra * 10;

                }
                return price; 
			}	
		}
	}
}
