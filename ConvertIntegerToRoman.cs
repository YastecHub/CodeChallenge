namespace CodeChallenge
{
    public class ConvertIntegerToRoman
    {
        public string IntToRoman(int num)
        {
            // Define the Roman numerals in descending order of value
            int[] values = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] symbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

            string result = "";


           // Iterate through each symbol, subtracting its value and Displaying the symbol
            for (int i = 0; i < values.Length && num > 0; i++)
            {
                while(num >= values[i])
                {
                    num -= values[i];
                    result += symbols[i];
                }
            }
            return result;
        }
    }
}