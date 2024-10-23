namespace CodeChallenge
{
    public class ConvertStringToInteger
    {
        public int ConvertingStringToInteger(string input)
        {
            //Initializing the boundaries given in the question
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;

            int index = 0;
            int result = 0;
            int sign = 1;
            int length = input.Length;
            
            //To Skip leading whitespaces as required
            while (index < length && input[index] == ' ')
            {
                index++;
            }

            //To Check for the sign of the number inputed
            if (index < length && (input[index] == '+' || input[index] == '-'))
            {
               if (input[index] == '-')
            {
                sign = -1;  
            }
             else
            {
              sign = 1;   
            }
                index++;  
            }

            //To Convert each digits to integer
            while (index < length && char.IsDigit(input[index]))
            {
                //Then Convert character to its integer value
                int digit = input[index] - '0';

                //To Check for potential overflow as expected in Question
                if (result > (maxInt - digit) / 10)
                {
                    // If adding this digit causes overflow, return the appropriate limit
                     Console.WriteLine("Overflow detected! Returning the closest boundary value.");
                     return (sign == 1) ? maxInt : minInt;
                }

                // Update result with the new digit
                result = result * 10 + digit;
                index++;
            }

            return result * sign;
        }
    }
}