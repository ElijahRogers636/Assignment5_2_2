namespace Assignment5_2_2
{
    internal class Program
    {
        //Write a program in C# Sharp to print the first n natural number using recursion.
        static void Main(string[] args)
        {
            RecursiveNaturalNumbers(10);
        }

        // Each recursive call adds the writeline on a stack until we reach base case (natNums = 1), then it starts poping off the top of the stack
        static void RecursiveNaturalNumbers(int natNums)
        {
            //Console.WriteLine(natNums); // 10->0
            if (natNums > 0)
            {
                //Console.WriteLine(natNums); //10->1
                RecursiveNaturalNumbers(natNums - 1);
                Console.WriteLine(natNums); //1->10
            }
            //Console.WriteLine(natNums); //0->10

        }
    }
}
