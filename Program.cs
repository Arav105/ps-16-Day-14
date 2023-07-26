using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_16
{
    public class Program
    {
        static void Main(string[] args)
        {
           
                try
                {
                Bank_accounts bank = new Bank_accounts(" Arav");
                    bool flag = true;
                    flag = bank.Deposit(3000);
                    flag = bank.Withdraw(500);
                    if (flag)
                        bank.Display();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
        }
    }
}
