using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Account
    {
        int acc_no=1000;
        String name;
        String address;
        String email;
        double balance;

        public Account(String tname,String tadd,String tmail,double tbal)
        {
            acc_no++;
            name = tname;
            address = tadd;
            email = tmail;
            balance = tbal;
        }

        virtual public void withdrawl(double amount)
        {
            balance = balance - amount;
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
        }

        public double getBalance()
        {
            return balance;
        }
        public String getName()
        {
            return name;
        }
        public String getAddress()
        {
            return address;
        }
        public String getMail()
        {
            return email;
        }
        public int getAccount()
        {
            return acc_no;
        }

        virtual public void printDetails()
        {
            ;
        }
    }
}
