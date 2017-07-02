using System;

namespace StartUp
{
    public class StartUp
    {
        public static void Main()
        {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            Console.WriteLine(DateModifier.CalculateDifference(str1, str2));
        }
    }
}
