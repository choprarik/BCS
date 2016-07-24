using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Factory
    {
        String f_name;
        String f_add;
        String f_mail;
        double f_op;

        public Account openAccount()
        {
            Account a=null;
            int ch;
            Console.WriteLine("Select the type of account:\n\t1. Savings\n\t2. Current");
            ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    a = openSavings();
                    break;
                case 2:
                    a = openCurrent();
                    break;
            }
            return a;
        }

        Account openSavings()
        {
            Account ac;
            Console.WriteLine("Enter details:\nName: ");
            f_name = Console.ReadLine();
            Console.WriteLine("Address: ");
            f_add = Console.ReadLine();
            Console.WriteLine("E-mail: ");
            f_mail = Console.ReadLine();
            Console.WriteLine("Opening Balance: ");
            f_op = Convert.ToDouble(Console.ReadLine());
            if(SavingsAccount.isValid(f_name, f_add, f_mail, f_op))
            {
                ac = new SavingsAccount(f_name, f_add, f_mail, f_op);
                ac.printDetails();
            }
            else
            {
                Console.WriteLine("Account cannot be created!");
                ac = null;
            }
            return ac;
        }

        Account openCurrent()
        {
            Account ac;
            double f_dl;
            Console.WriteLine("Enter details:\nName: ");
            f_name = Console.ReadLine();
            Console.WriteLine("Address: ");
            f_add = Console.ReadLine();
            Console.WriteLine("E-mail: ");
            f_mail = Console.ReadLine();
            Console.WriteLine("Opening Balance: ");
            f_op = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Draft Limit: ");
            f_dl = Convert.ToDouble(Console.ReadLine());
            if (CurrentAccount.isValid(f_name, f_add, f_mail, f_op))
            {
                ac = new CurrentAccount(f_name, f_add, f_mail, f_op,f_dl);
                ac.printDetails();
            }
            else
            {
                Console.WriteLine("Account cannot be created!");
                ac = null;
            }
            return ac;
        }
    }
}
