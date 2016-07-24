using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fac = new Factory();
            Account acc=null;

            int choice = 0,w=0;
            double amt;

            do
            {
                Console.WriteLine("Please select one option:\n1. Open new account\n2. Withdraw\n3. Deposit\n4. View Details");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        acc = fac.openAccount();
                        break;

                    case 2:
                        if (acc != null)
                        {
                            Console.WriteLine("Enter withdrawl amount: ");
                            amt = Convert.ToDouble(Console.ReadLine());
                            acc.withdrawl(amt);
                            acc.printDetails();
                        }
                        break;

                    case 3:
                        if (acc != null)
                        {
                            Console.WriteLine("Enter deposit amount: ");
                            amt = Convert.ToDouble(Console.ReadLine());
                            acc.deposit(amt);
                            acc.printDetails();
                        }
                        break;

                    case 4:
                        if (acc != null)
                        {
                            acc.printDetails();
                        }
                        break;

                    default:
                        Console.WriteLine("Some Error Occurred!");
                        break;
                }
                Console.WriteLine("To continue press 1");
                w = Convert.ToInt32(Console.ReadLine());
            } while (w == 1);
        }
    }
}
