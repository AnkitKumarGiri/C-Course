using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DelegateCodingChallenge
{
    public delegate void ShippingFeesDelegate(decimal thePrice, ref decimal fee);
    public abstract class ShippingDestination
    {
        public bool isHighRisk;
        public virtual void calcFees(decimal thePrice, ref decimal fee) { } // remember virtual functions need to be implemented in child classes. We want to create a child class for each zone
        // Why? Why not just create individual functions for each zone and return the corresponding one. Well it would not work if we had to expose mulitple functions for a zone other than just
        // shipping fees. Creating a class allows us to bundle all these functionalities into a single object entity and return it.

        public static ShippingDestination getDestinationInfo(string dest)
        {
            if (dest.Equals("zone1"))
            {
                return new Dest_Zone1();
            }
            if (dest.Equals("zone2"))
            {
                return new Dest_Zone2();
            }
            if (dest.Equals("zone3"))
            {
                return new Dest_Zone3();
            }
            if (dest.Equals("zone4"))
            {
                return new Dest_Zone4();
            }
            return null;
        }
    }

    public class Dest_Zone1 : ShippingDestination
    {
        public Dest_Zone1()
        {
            isHighRisk = false;
        }
        public override void calcFees(decimal thePrice, ref decimal fee)
        {
            fee = thePrice * 0.25m;
        }
    }
    public class Dest_Zone2 : ShippingDestination
    {
        public Dest_Zone2()
        {
            isHighRisk = true;
        }
        public override void calcFees(decimal thePrice, ref decimal fee)
        {
            fee = thePrice * 0.12m;
        }
    }
    public class Dest_Zone3 : ShippingDestination
    {
        public Dest_Zone3()
        {
            isHighRisk = false;
        }
        public override void calcFees(decimal thePrice, ref decimal fee)
        {
            fee = thePrice * 0.08m;
        }
    }
    public class Dest_Zone4 : ShippingDestination
    {
        public Dest_Zone4()
        {
            isHighRisk = true;
        }
        public override void calcFees(decimal thePrice, ref decimal fee)
        {
            fee = thePrice * 0.04m;
        }
    }
}
