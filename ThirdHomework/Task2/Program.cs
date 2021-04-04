using System;

namespace Task2
{
    class Program
    {
        static void ExtraSpaceRemove(string methodInput)
        {
            string refinedInput = methodInput.Trim();
            char[] refinedInputArray = refinedInput.ToCharArray();
            int counter = 0;
            char[] resultArray = new char[1000];

            for (int i = 0; i < refinedInputArray.Length; i++)
            {
                if (refinedInputArray[i] == ' ' && refinedInputArray[i + 1] == ' ')
                {
                    continue;
                }
                else
                {
                    //Console.Write(refinedInputArray[i]);
                    resultArray[counter] = refinedInputArray[i];
                    counter++;
                }
                
            }
            string result = new string(resultArray);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            // Create a new method that will remove extra space characters

            Console.WriteLine("Extra space characters removing");

            string inputString = "Call the method with the following text: The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            string test = "             THIS is a               test            ";

            ExtraSpaceRemove(inputString);

            Console.ReadLine();
        }
    }
}
