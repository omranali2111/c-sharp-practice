
using static System.Console;
using System;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        int day, month, num, num1, totl, totl1, n1, p2;
        char chr, grd;
        string strg;

        WriteLine("enter number of a month(1-12): ");
        month = int.Parse(ReadLine());
        theMonth(month);
        WriteLine("************************************");
        WriteLine("enter a char: ");
        chr = (ReadLine()[0]);
        letter(chr);
        WriteLine("************************************");
        WriteLine("enter your grade: ");
        grd = (ReadLine()[0]);
        theGrade(grd);
        WriteLine("************************************");
        WriteLine("enter number of a day(1-7): ");
        day = int.Parse(ReadLine());
        theDay(day);
        WriteLine("************************************");
        WriteLine("enter number to Calculate Fibonacci Series: ");
        num = int.Parse(ReadLine());
        // Program obj = new Program();
        //obj.nth(num);
        WriteLine(nth(num));
        WriteLine("************************************");

        WriteLine("Enter a number to calculate  the factorial: ");
        num1 = int.Parse(ReadLine());

        WriteLine("Factorial of " + num1 + " is " + factorial(num1));
        WriteLine("************************************");
        WriteLine("Enter a number to calculate  the power: ");
        totl = int.Parse(ReadLine());

        WriteLine("Enter a number of power: ");
        totl1 = int.Parse(ReadLine());

        WriteLine(power(totl, totl1));

        WriteLine("************************************");
        WriteLine("Enter a number to calculate  the power: ");
        n1 = int.Parse(ReadLine());

        WriteLine("Enter a number of power: ");
        p2 = int.Parse(ReadLine());

        WriteLine(powerRecursion(n1, p2));

        WriteLine("************************************");
        WriteLine("write a string to check if it's palindrom ");
        strg=Convert.ToString(ReadLine());
        WriteLine(palindrome(strg));





    }

    static void letter(char chr)
    {
        // task 1
        char a, e, i, o, u;



        switch (chr)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                WriteLine("this is Vowel letter");
                break;

            default:
                WriteLine("this is Consonant letter");
                break;



        }

    }
    //task 2

    static void theMonth(int month)

    {

        switch (month)
        {
            case 1:
                WriteLine("January");
                break;
            case 2:
                WriteLine("February");
                break;
            case 3:
                WriteLine(" March");
                break;
            case 4:
                WriteLine("April");
                break;
            case 5:
                WriteLine("May");
                break;
            case 6:
                WriteLine("June");
                break;
            case 7:
                WriteLine("July");
                break;
            case 8:
                WriteLine("August");
                break;
            case 9:
                WriteLine(" September");
                break;
            case 10:
                WriteLine("October");
                break;
            case 11:
                WriteLine("November");
                break;
            case 12:
                WriteLine("December");
                break;
            default:
                WriteLine("You have entered invalid number");
                break;
        }
    }
    //task 3

    static void theGrade(char grd)
    {
        char A, B, C, D, F;
        switch (grd)
        {
            case 'A':
                WriteLine("excellent performance");
                break;
            case 'B':
                WriteLine("Good performance");
                break;
            case 'C':
                WriteLine("Average performance");
                break;
            case 'D':
                WriteLine("Below Average performance");
                break;
            case 'F':
                WriteLine("Failure performance");
                break;

            default:
                WriteLine("invalid letter");
                break;

        }
    }

    //task 4
    static void theDay(int day)
    {
        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("monday");
                break;
            case 3:
                Console.WriteLine("tuesday");
                break;
            case 4:
                Console.WriteLine("wednesday");
                break;
            case 5:
                Console.WriteLine("thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("saturday");
                break;
            default:
                WriteLine("You have entered invalid number");
                break;
        }
    }
    // C# Recursion function tasks
    //task 1 Fibonacci Calculator
    static int nth(int num)
    {

        if ((num == 0) || (num == 1))
        {
            return num;
        }
        else

            return nth(num - 1) + nth(num - 2);



    }

    static int factorial(int num)
    {
        // termination condition
        if (num == 0)
            return 1;
        else
            // recursive call
            return num * factorial(num - 1);



    }
    // calculate the power of number 
    static int power(int numb, int pwr)
    {
        int value = numb;
        for (int i = 2; i <= pwr; i++)
        {

            value = value * numb;
        }
        return value;
    }
    //calculate the power of number using Recursion  

    static int powerRecursion(int n1, int p2)
    {
        if (p2 == 0)
        {
            return 1;
        }
        if (p2 == 1)
        {
            return n1;
        }
        else
            return n1 * powerRecursion(n1, p2 - 1);
    }
    //palindrome (check if string is palindrome)
    static string palindrome(string strg)
    {
        int length = strg.Length;


        if (strg[0] != strg[length-1])
        {
            
            return "not palindrome";
        }
        else if(strg[0] == strg[length - 1])
        {
            return " palindrome";
        }

        return palindrome(strg.Substring(1, strg.Length - 2));
      
    }
}




    

