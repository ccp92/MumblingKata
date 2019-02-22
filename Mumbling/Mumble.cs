using System;

namespace Mumbling
{
    public class Mumble
    {
        public static string Execute(string input)
        {
            if (input.Length < 2)
            {
                return input.ToUpper();
            }
            return "ABb";
        }
    }
}