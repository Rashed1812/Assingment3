namespace Assingment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            Console.WriteLine("Enter Number divided by 3 and 4 :");
            int Num = int.Parse(Console.ReadLine());

            if ((Num % 4 == 0) && (Num % 3 == 0)) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
            #endregion


            Console.ReadKey();
        }
    }
}