using System.Xml.Linq;

namespace Assignment4
{
    internal class Program
    {
        public static void BankApp()
        {
            int number = 0;
            int value = 0;
            BankAccount tester =null;
            do
            {
                
                Console.WriteLine("1.Create new account\n" +
                "2. Make deposit\n" +
                "3. Make withdrawal\n" +
                "4. Show balance\n" +
                "5. Show transactions\n" +
                "6. Leave ");
                Console.WriteLine("Enter a number:");
                number = int.Parse(Console.ReadLine());
                if (number == 1) value++;
                while (value == 0)
                {
                    Console.WriteLine("First of all, You should create an account to continue!");
                    Console.WriteLine("Enter a number again:");
                    number = int.Parse(Console.ReadLine());
                    if (number == 1) value++;
                }
                if (number == 1)
                {
                    Console.WriteLine("Enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your intial balance:");
                    int balance = int.Parse(Console.ReadLine());
                    tester=new BankAccount(name, balance);
                }

                else if (number == 2)
                {
                    Console.WriteLine("Enter amount:");
                    int amount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your description:");
                    string description = Console.ReadLine();
                    DateTime dateTime = DateTime.Now;
                    tester.Deposit(amount,dateTime, description);
                }
                else if (number == 3)
                {
                    Console.WriteLine("Enter amount:");
                    int amount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your description:");
                    string description = Console.ReadLine();
                    DateTime dateTime = DateTime.Now;
                    tester.Withdrawal(amount, dateTime, description);
                }
                else if (number == 4)
                {
                    Console.WriteLine($"Your balance: {tester.BalanceValue()}");
                }
                else if (number == 5)
                {
                    Console.WriteLine(tester.TransactionsHistory()); 
                }
                else if (number == 6)
                {
                    Console.WriteLine("End!");
                    break;
                }
                    } while (number != 6);
        }
        static void Main(string[] args)
        {
            BankApp();
        }
    }
}
