namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var MyMoney = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            Console.WriteLine();
            var funds = double.Parse(Console.ReadLine());
            Console.WriteLine();
            MyMoney.Deposit(funds);
            Console.WriteLine();
            Console.WriteLine($"Ok, {funds} has been deposited to your account.");
            Console.WriteLine();


            Console.WriteLine($"Would you like to retrive your balance? y/n");
            var response = (Console.ReadLine());

            if (response == "y")
            {
                Console.WriteLine($"Your new balance is {MyMoney.GetBalance()}");
                Console.WriteLine("Thank you for banking with Rufus First Federal!");
            }
            else
            {
                Console.WriteLine("Thank you for banking with Rufus First Federal!");
            }
        }
    }
}
