using System;

namespace StringCutter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("Please enter a word");
                string str = Console.ReadLine();
                WriteNewString(str);

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
            }
        }

        static void WriteNewString(string str)
        {
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    newStr += str.Substring(i, 1);
                }
            }
            Console.WriteLine(newStr);

        }
    }
}
