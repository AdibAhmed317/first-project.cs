using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter your department: ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Your name is "+ name);
            Console.WriteLine("Your ID is "+ id);
            Console.WriteLine("Your department is "+ dept);
            Console.WriteLine("Your course name is "+ courseName);

            Console.WriteLine("");

            int vowel = 0;
            int cons = 0;

            string lowerCaseName = name.ToLower();
            string replaceChar = lowerCaseName.Replace(" ", "");

            for (int i=0; i<replaceChar.Length; i++)
            {
                if (lowerCaseName[i] =='a' || lowerCaseName[i] =='e' || lowerCaseName[i] =='i' || lowerCaseName[i] == 'o')                                            
                {
                    vowel++;
                }
                else
                {
                    cons++;
                }
            }

            Console.WriteLine("There are " + vowel + " vowel and " + cons + " consonant.");
        }
    }
}
