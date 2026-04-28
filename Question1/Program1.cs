namespace Task3
{
    internal class Program1
    {
        // Shani Maroz
        // 211579263
        static void Main(string[] args)
        {
            // Testing the regular account
            Account withdrawTry = new Account(111545, 2000);
            withdrawTry.Withdraw(3000);

            // testing the VIP account
            VipAccount vipWithdrawTry = new VipAccount(11151, 2000);
            vipWithdrawTry.Withdraw(3000);

            // Demonstrating polymorphism
            Account specialAcc = new VipAccount(123, 2000);
            specialAcc.Withdraw(3000);
        }
    }
}
