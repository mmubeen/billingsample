using System;

namespace Billing
{
    class Program
    {
        static void Main(string[] args)
        {
            var posOnline = new Pos();
            var input = "Y";
            do
            {
                Console.WriteLine("Enter 1,2,3,4, B to Print Bill or N to stop billing or R to clear order.");
                input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "B":
                        Console.Write(posOnline.displayBill());
                        break;
                    case "R":
                        posOnline.reset();
                        Console.Write(posOnline.displayBill());
                        break;
                    default:
                        int.TryParse(input, out int selectId);
                        if (selectId > 0)
                            posOnline.orderItem(selectId);
                        else
                            input = "Y";
                        break;
                }
            } while (input != "N");

            Console.WriteLine("Pos going off line");
            Environment.Exit(0);
        }
    }
}
