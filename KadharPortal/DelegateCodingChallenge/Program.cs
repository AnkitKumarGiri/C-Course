//using System;

//namespace DelegateCodingChallenge
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ShippingDestination destInfo;
//            ShippingFeesDelegate theDel;

//            string zoneInput;
//            do
//            {
//                // get the zone input from the user
//                Console.WriteLine("What is the destination zone?");
//                zoneInput = Console.ReadLine();
//                if (zoneInput == "exit")
//                {
//                    break;
//                }
//                // get the appropriate zone object from Shipping Destination
//                destInfo = ShippingDestination.getDestinationInfo(zoneInput);
//                if (destInfo == null)
//                {
//                    Console.WriteLine("Seems like you entered an incorrect address. It does not exist. Please try again.");
//                    continue;
//                }

//                theDel = destInfo.calcFees;

//                // get the prime of the item
//                decimal itemPrice;

//                do
//                {
//                    Console.WriteLine("What is the item price?");
//                    try
//                    {
//                        itemPrice = decimal.Parse(Console.ReadLine());
//                        break;
//                    }
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine("Error: {0}\n Please enter a valid price", ex.Message.ToString());
//                    }
//                } while (true);

//                // the reason why the calcFees function has void return type is to facilitate chaining of delegates. Here we can chain another delegate if the zone is high risk
//                if (destInfo.isHighRisk)
//                {
//                    theDel += delegate (decimal thePrice, ref decimal theFee)
//                    {
//                        theFee += 25.0m; // add 25 units to the price
//                    };
//                }
//                // now we are ready to calculate the fee

//                decimal finalFee = 0.0m;
//                theDel(itemPrice, ref finalFee);
//                Console.WriteLine("The Shipping Fees is: {0}", finalFee);

//            } while (zoneInput != "exit");
//        }
//    }
//}
