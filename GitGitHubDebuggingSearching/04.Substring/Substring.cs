using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';  // tricky this 'p' is now the english 'p' // ascii code differrent :D
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            char charOfI = text[i]; // declaring char for index of i or isnt works
            if (charOfI == Search)
            {
                hasMatch = true;

                int endIndex = jump + 1; // jump haves to be + 1 pos

                if (endIndex  + i > text.Length) // endIndex have to be mutiply by i-index
                {
                    endIndex = text.Length - i; // and if is true endIndex is equal to text leghnt - 1
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
