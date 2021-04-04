using System;

namespace Task1
{
    class Program
    {

        static void FunWithStrings(string methodInput)
        {
            //print the reverse string
            char[] methodInputToCharArray = methodInput.ToCharArray();
            Array.Reverse(methodInputToCharArray);
            string reversedArray = new string(methodInputToCharArray);
            Console.WriteLine("This is the string in reverse: " + reversedArray);

            //print total number of vowels
            string lower = methodInput.ToLower();
            int vowelCounter = 0;

            for (int i = 0; i < lower.Length; i++)
            {
                if (lower[i] == 'a' || lower[i] == 'e' || lower[i] == 'i' || lower[i] == 'o' || lower[i] == 'u')
                {
                    vowelCounter++;
                }
            }

            Console.WriteLine("The total number of vowels in the string entered is: " + vowelCounter);

            //check if string is palindrome

            char[] reversedLower = lower.ToCharArray();
            Array.Reverse(reversedLower);
            string reversedLowerString = new string(reversedLower);

            if (lower == reversedLowerString)
            {
                Console.WriteLine("Entered string is a palindrome");
            }
            else
            {
                Console.WriteLine("Entered string is NOT a palindrome");
            }

            //print the largest word
            //print the smallest word
            //print the count of words

            string[] LongestAndShortestWord = methodInput.Split(new[] { " " }, StringSplitOptions.None);
            int min = int.MaxValue;
            int max = int.MinValue;
            int wordCount = 0;
            string shortestWord = " ";
            string longestWord = " ";
            

            for (int i = 0; i < LongestAndShortestWord.Length; i++)
            {
                if (LongestAndShortestWord[i].Length > max)
                {
                max = LongestAndShortestWord[i].Length;
                longestWord = LongestAndShortestWord[i];
                }
                if (LongestAndShortestWord[i].Length < min)
                {
                min = LongestAndShortestWord[i].Length;
                shortestWord = LongestAndShortestWord[i];
                }
                wordCount = i + 1;
            }
            Console.WriteLine("The longest word is: " + longestWord);
            Console.WriteLine("The shortest word is: " + shortestWord);
            Console.WriteLine("The total word count in the string is: " + wordCount);

            //print the most used character(not space obviously)
            char mostUsedChar = ' ';
            int mostUsedCharCount = 0;

            for (int i = 0; i < methodInput.Length; i++)
            {
                int counterForThisCycle = 0;

                for (int c = 0; c < methodInput.Length; c++)
                {
                    if (methodInput[i] == methodInput[c]) counterForThisCycle++;
                    if (counterForThisCycle > mostUsedCharCount && methodInput[i] != ' ')
                    {
                        mostUsedCharCount = counterForThisCycle;
                        mostUsedChar = methodInput[i];
                    }
                }
            }

            Console.WriteLine("The most used character is: " +  mostUsedChar + " and it is used: " + mostUsedCharCount + " times");

        }

        static void Main(string[] args)
        {
            //            Create a new method called FunWithStrings that will have one input parameter(string) and it will have no return
            //In that method you should display in console the following tasks for the string:
            //print the reverse string
            //print total number of vowels
            //check if string is palindrome
            //print the largest word
            //print the smallest word
            //print the count of words
            //print the most used character(not space obviously)
            //Ask the user to enter a string and call the method with that string.

            string userInput = "This is a test string!";
            Console.WriteLine("Enter a string to have some fun with it");
            userInput = Console.ReadLine();

            FunWithStrings(userInput);

            Console.ReadLine();
        }
    }
}
