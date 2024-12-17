using System.Diagnostics.Metrics;

namespace Assingment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            //Console.WriteLine("Enter Number divided by 3 and 4 :");
            //int Num = int.Parse(Console.ReadLine());

            //if ((Num % 4 == 0) && (Num % 3 == 0)) { Console.WriteLine("Yes"); }
            //else { Console.WriteLine("No"); }
            #endregion

            #region Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive
            //Console.WriteLine("Enter Number if it is negative number or positive :");
            //int Num = int.Parse(Console.ReadLine());

            //if ((Num > 0 )){ Console.WriteLine("positive"); }
            //else { Console.WriteLine("Negative"); }
            #endregion

            #region Write a program that takes 3 integers from the user then prints the max element and the min element
            //Console.WriteLine("First Number :");
            //int Num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Second Number :");
            //int Num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Third Number :");
            //int Num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("max element = " + Math.Max(Num1, Math.Max(Num2, Num3)));
            //Console.WriteLine("min element = " + Math.Min(Num1, Math.Min(Num2, Num3)));
            #endregion

            #region Write a program that allows the user to insert an integer number then check If a number is even or odd
            //Console.WriteLine("Enter Number To Check It iS Even or Odd :");
            //int Num = int.Parse(Console.ReadLine());

            //if ((Num % 2 == 0)) { Console.WriteLine("Even"); }
            //else { Console.WriteLine("Odd"); }
            #endregion

            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)
            //Console.WriteLine("Write a character To Know if it vowel or consonant: ");
            //char Inputcharacter1 = char.Parse(Console.ReadLine());
            //char character2 = char.ToLower(Inputcharacter1);

            //if (character2 == 'a'|| character2 =='e'|| character2 == 'i'|| character2 =='o'|| character2 =='u') { Console.WriteLine("Vowel"); }
            //else { Console.WriteLine("Consonant");}
            #endregion

            #region Write a program that allows the user to insert an integer then print a multiplication table up to 12

            //Console.WriteLine("Write Number: ");
            //int inputNum = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= 12; i++) { Console.Write($"{i*inputNum} "); }
            #endregion

            #region Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Write Number To Know even numbers between 1 to this number: ");
            //int inputNum = int.Parse(Console.ReadLine());

            //for (int i = 1; i < inputNum; i++) { if (i%2 == 0) { Console.Write($"{i} "); } }
            #endregion

            #region Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter First Number You Want to Get The power : ");
            //float inputNum = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Power Number: ");
            //float Power = float.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Pow(inputNum, Power));
            #endregion

            #region Write a program to enter marks of five subjects and calculate total, average and percentage
            //Console.WriteLine("Enter Marks of five subjects");

            //Console.Write("Subject 1: ");
            //int subject1 = int.Parse(Console.ReadLine());
            //Console.Write("Subject 2: ");
            //int subject2 = int.Parse(Console.ReadLine());
            //Console.Write("Subject 3: ");
            //int subject3 = int.Parse(Console.ReadLine());
            //Console.Write("Subject 4: ");
            //int subject4 = int.Parse(Console.ReadLine());
            //Console.Write("Subject 5: ");
            //int subject5 = int.Parse(Console.ReadLine());

            //int total = subject1 + subject2 + subject3 + subject4 + subject5;
            //double average = total / 5;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine($"Total = {total}");
            //Console.WriteLine($"Average = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region  Write a program to input the month number and print the number of days in that month
            //Console.Write("Enter the month number :");
            //int Month = int.Parse(Console.ReadLine());
            //int days;

            //switch (Month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //         days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        Console.Write("Enter the year to check for leap year: ");
            //        int year = int.Parse(Console.ReadLine());
            //        days = (DateTime.IsLeapYear(year)) ? 29 : 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            //        return ;
            //}

            //Console.WriteLine($"Days in Month: {days}");
            #endregion

            #region Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task
            //Console.WriteLine("Enter Hours You Take To Complete The Job");
            //double efficiencyTime = double.Parse(Console.ReadLine());

            //if (efficiencyTime >= 2 && efficiencyTime < 3) { Console.WriteLine("highly efficient"); }
            //else if (efficiencyTime >= 3 && efficiencyTime < 4) { Console.WriteLine("increase Your speed"); }
            //else if (efficiencyTime >= 4 && efficiencyTime <=5) { Console.WriteLine(" you are provided with training to enhance your speed"); }
            //else if (efficiencyTime > 5) { Console.WriteLine("you are required to leave the company"); }
            //else {Console.WriteLine("Invalid Input Please Time is should be 2 hours atleast");}


            #endregion

            Console.ReadKey();
        }

    }
}