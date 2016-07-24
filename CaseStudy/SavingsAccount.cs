using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class SavingsAccount:Account
    {
        const double MIN_BAL = 1000.0;

        public SavingsAccount(String sname, String sadd, String smail, double op_bal) :base(sname,sadd,smail,op_bal)
        {
        }

        public override void withdrawl(double amount)
        {
            double bal = getBalance();
            if ((bal - amount) <= MIN_BAL)
            {
                Console.WriteLine("Low balance! Cannot withdraw.");
            }
            else
            {
                base.withdrawl(amount);
            }
        }

        public static bool isValid(String sname,String sadd,String smail,double op_bal)
        {
            if(sname.Length==0 || sadd.Length==0 || smail.Length==0 || op_bal<=10000.0)
            {
                return false;
            }
            return true;
        }

        override public void printDetails()
        {
            Console.WriteLine("###################################################");
            Console.WriteLine("Account Number: " + getAccount().ToString());
            Console.WriteLine("\n\tName: " + getName());
            Console.WriteLine("\tAddress: " + getAddress());
            Console.WriteLine("\tE-mail: " + getMail());
            Console.WriteLine("\n\tAccount Type: SAVINGS");
            Console.WriteLine("\nBalance: " + getBalance().ToString());
            Console.WriteLine("###################################################");
        }

    }
}
