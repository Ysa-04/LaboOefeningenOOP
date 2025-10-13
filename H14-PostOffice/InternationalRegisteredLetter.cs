using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H14_PostOffice
{
    internal class InternationalRegisteredLetter : RegisteredLetter
    {
        public override byte Duration
        {
            get
            {
                return Convert.ToByte(Math.Ceiling(Distance / 50));
            }
        }

        public override double Price
        {
            get
            {
                if (Distance < 100)
                {
                    return 20;
                }
                else
                {
                    double extra = Math.Ceiling((Distance / 100)*20);
                    return 20 * extra;

                }
            }
        }
    }

}
