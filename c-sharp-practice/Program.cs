
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        char a, e, i, o, u, chr;

        WriteLine("enter a char: ");
        chr=(ReadLine()[0]);

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
}