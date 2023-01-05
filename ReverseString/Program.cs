namespace ReverseString
{
    internal class Program
    {
        public static string ReverseString(string stringIn)
        {
            string reverseString = "";
            for (int i = stringIn.Length - 1; i >= 0; i--)
            {
                reverseString += stringIn[i];
            }
            return reverseString;
        }

        static void Main(string[] args)
        {
            string[] test =  
                {"helloWorld", 
                "dog", 
                "tool", 
                "draw", 
                "willTheRealSlimShadyPleaseStandUp"};

            foreach (string strInput in test)
            {
                Console.WriteLine("String Input: " + strInput);
                Console.WriteLine(ReverseString(strInput));
            }
        }
    }
}