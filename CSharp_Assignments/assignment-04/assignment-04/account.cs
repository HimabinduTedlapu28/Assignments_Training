using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_04
{
    class account
    {
        int Accountno;
        string CustomerName;
        string Accounttype;
        string Transactiontype;
        int Amount;
        int balance;

    public account
            {
            public int Accountno;
            public string Customername;


            
            






        static void Main()
        {
            account a = new account();
            Console.WriteLine("Enter the Accountno :  ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Accounttype : ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the Transactiontype : ");
            string Trans = Console.ReadLine();
            Console.WriteLine("Enter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the balance : ");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();








        }
    }
}
