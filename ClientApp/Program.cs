namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommonFunctions.NumericFunctions numericFunctions = new CommonFunctions.NumericFunctions();

            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Add ");
            int ch = Byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine(numericFunctions.Add(1, 2, 3, 4, 5, 65, 67, 7));
                    break;
                case 2:
                    int? num1 = null;
                    int num2 = 20;
                    num1 = Int32.TryParse(Console.ReadLine(), out int i) ? i : null;
                    numericFunctions.Subtract(num1, num2);
                    break;


            }
        }
    }
}