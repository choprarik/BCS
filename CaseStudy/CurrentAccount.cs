using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class CurrentAccount:Account
    {
        double od_limit;

        public CurrentAccount(String sname, String sadd, String smail, double op_bal,double od) :base(sname,sadd,smail,op_bal)
        {
            od_limit = od;
        }

        public override void withdrawl(double amount)
        {
            double bal = getBalance();
            if (((bal+od_limit) - amount) <= 0)
            {
                Console.WriteLine("Low balance! Cannot withdraw.");
            }
            else
            {
                base.withdrawl(amount);
            }
        }

        public static bool isValid(String sname, String sadd, String smail, double op_bal)
        {
            if (sname.Length == 0 || sadd.Length == 0 || smail.Length == 0 || op_bal <= 5000.0)
            {
                return false;
            }
            return true;
        }

        override public void printDetails()
        {
            Console.WriteLine("###################################################");
            Console.WriteLine("Account Number: "+getAccount().ToString());
            Console.WriteLine("\n\tName: " + getName());
            Console.WriteLine("\tAddress: " + getAddress());
            Console.WriteLine("\tE-mail: " + getMail());
            Console.WriteLine("\n\tAccount Type: CURRENT");
            Console.WriteLine("\nBalance: " + getBalance().ToString());
            Console.WriteLine("###################################################");
        }
    }
}
