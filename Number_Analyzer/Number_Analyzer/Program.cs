using System;

namespace Number_Analyzer
{
    class Program
    {
        //Comments: Looks good! Can't break it!
        public static string userName;
        public static int userNumber;

        static void Main(string[] args)
        {
            NumberAnalyzer();
        }

        public static void NumberAnalyzer()
        {
            NameUpperCaser();

            Console.WriteLine($"Thank you {userName}. Please enter a number 1 - 100.");

            string value = Console.ReadLine();
            while (true)
            {
                while (!int.TryParse(value, out userNumber))
                {
                    Console.WriteLine("Please enter a numeric value. Try again.");
                    value = Console.ReadLine();
                }

                if (!WithinRange(userNumber, 0, 100))
                {
                    Console.WriteLine("Please enter a number between 1-100. Try again.");
                    value = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            Analyze();
        }

        public static string NameUpperCaser()
        {
            Console.WriteLine("Welcome to 'Number Analyzer'. Before we begin, can I get your name please?");
            userName = Console.ReadLine();
            char[] capitalize = userName.ToCharArray();
            capitalize[0] = char.ToUpper(capitalize[0]);
            //userName = capitalize.ToString(); this line does not work
            userName = new string(capitalize);
            return userName;

            /*
            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
             */
        }

        public static bool WithinRange(int x, int min, int max)
        {
            return x >= min && x <= max;
        }

        public static void Analyze()
        {
            if (userNumber % 2 == 0)
            {
                if (userNumber >= 2 && userNumber <= 24)
                {
                    Console.WriteLine($"{userName}, {userNumber} is : Even and less than 25.");
                    TryAgain();
                }

                else if (userNumber >= 26 && userNumber <= 60)
                {
                    Console.WriteLine($"{userName}, {userNumber} is : Even and between 26 and 60.");
                    TryAgain();
                }

                else
                {
                    Console.WriteLine($"{userName}, {userNumber} is : Even and greater than 60.");
                    TryAgain();
                }
            }

            else
            {
                if (userNumber <= 60)
                {
                    Console.WriteLine($"{userName}, {userNumber} is : Odd and less than 60.");
                    TryAgain();
                }

                else
                {
                    Console.WriteLine($"{userName}, {userNumber} is : Odd and greater than 60.");
                    TryAgain();
                }
            }
        }

        public static void TryAgain()
        {
            Console.WriteLine("Would you like to try again? Enter 'y' or 'yes' to continue.\nEnter 'n' or 'no' to exit program.");
            string restart = Console.ReadLine().ToUpper();

            switch (restart)
            {
                case "Y":
                    NumberAnalyzer();
                    break;

                case "YES":
                    NumberAnalyzer();
                    break;

                default:
                    Console.WriteLine($"Exiting Program. Goodbye {userName}!");
                    break;
            }
        }
    }
}
