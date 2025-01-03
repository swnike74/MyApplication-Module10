namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc1 calculator = new Calc1();

            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Calculator of Sum: a + b");
                    Console.WriteLine("Enter digit a:");
                    int numberA = Convert.ToInt32(Console.ReadLine());
                    if (numberA.GetType().ToString() != "System.Int32") throw new FormatException();

                    Console.WriteLine("Enter digit b:");
                    int numberB = Convert.ToInt32(Console.ReadLine());
                    if (numberB.GetType().ToString() != "System.Int32") throw new FormatException();

                    Console.WriteLine("Результат:{0}",calculator.Sum(numberA,numberB));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено неверное значение");
                }
            }
        }
    }
}
