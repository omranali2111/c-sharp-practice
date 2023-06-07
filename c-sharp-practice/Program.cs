
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        int month;
        char chr,grd;

        WriteLine("enter number of a month(1-12): ");
        month = int.Parse(ReadLine());
        theMonth(month);
        
        WriteLine("enter a char: ");
        chr = (ReadLine()[0]);
        letter(chr);

        WriteLine("enter your grade: ");
        grd = (ReadLine()[0]);
        theGrade(grd);


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
        switch(grd)
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


       
    }


    

