namespace Assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer greater than 1 to print every number from input down to 1");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int i = printNumbers(userInput);



            static int printNumbers(int input)
            {
                if (input < 1) { Console.WriteLine("invalid input"); return 0; }
                if (input == 1)
                {
                    Console.WriteLine("1");
                    Console.WriteLine("Program complete");
                    return 1;
                }
                if (input > 1)
                {
                    Console.WriteLine(input);
                    input--;
                    printNumbers(input);
                }
                return 0;
            }
        }
    }
}
