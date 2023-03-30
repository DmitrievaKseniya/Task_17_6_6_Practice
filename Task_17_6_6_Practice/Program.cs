using Task_17_6_6_Practice.TypeAccount;

namespace Task_17_6_6_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculateInterest(new OrdinaryAccount());
            Calculator.CalculateInterest(new OrdinaryAccount());
        }
    }
}