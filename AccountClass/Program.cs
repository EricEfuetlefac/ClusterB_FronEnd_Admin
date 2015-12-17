using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAccount account = new MyAccount();
            Console.WriteLine("100 Deposited: " + account.deposit(50));
            Console.WriteLine("50 withdrawed: " + account.withdraw(75));
            Console.ReadLine();
        }


    }
}
