using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityChallenge_IncrementArray
{
    class ArrayIncrementer
    {
        public int[] Solution(int[] A)
        {
            int[] temp = new int[] { };
            // Check the array length
            if (A.Length == 0 || A.Length > 8)
                return temp;

            // Check the array for leading 0
            if (A[0] == 0)
                return temp;

            // Convert the array to a string
            string digits = string.Join("", A);

            try
            {
                // Check the string's value
                if (Convert.ToInt32(digits) < 0 || Convert.ToInt32(digits) > 1000000)
                {
                    Console.WriteLine("Input must be between 1 and 1,000,000");
                    return temp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Array: " + ex.Message);
                return temp;
            }

            // Check for integers only
            string pattern = "[0-9]+";
            if (System.Text.RegularExpressions.Regex.IsMatch(digits, pattern))
            {
                int newDigits = Convert.ToInt32(digits) + 1;
                Console.WriteLine("Original number: " + digits);
                Console.WriteLine("New number:      " + newDigits);

                int[] result = newDigits.ToString().Select(o => Convert.ToInt32(o)).ToArray();

                printArray(result);

                return result;
            }
            Console.WriteLine("Array cannot contain characters.");
            return temp;
        }
        private void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Encoding encoding = ASCIIEncoding.ASCII;

                Console.WriteLine("ASCII[" + i + "]: " + array[i] + "\tChar[" + i + "]: " + (char)array[i]);
            }
        }
    }
}
