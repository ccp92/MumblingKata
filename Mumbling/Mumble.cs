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

            string upperInput = Upper(input);

            string duplicatedInput = Duplicate(upperInput);

            return duplicatedInput;
        }

        private static string Upper(string input)
        {
            string upperInput = string.Empty;

            foreach (char c in input)
            {
                upperInput += char.ToUpper(c);
            }
            
            return upperInput;
        }

        private static string Duplicate(string input)
        {
            string duplicatedInput = string.Empty;
            int counter = 0;
            foreach (char c in input)
            {
                duplicatedInput += c;
                for (int i = 0; i < counter; i++)
                {
                    duplicatedInput += char.ToLower(c);
                }
                counter += 1;
            }

            return duplicatedInput;
        }
    }
}