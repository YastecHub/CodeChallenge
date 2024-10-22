namespace CodeChallenge
{
    public class ReverseInteger
    {
        public int ReversingOfInteger(int x)
        {
            int reversed = 0;

            if (x ==int.MinValue)
            {
                Console.WriteLine("Number Entered has exceeded the int value to be reversed");
            }
//Logic to handle the sign in fron of the number
        //and Work with the absolute value
            int sign = x < 0 ? -1 : 1;  
            x = Math.Abs(x);
           
           while (x > 0)
           {
            //Logic to Extract the last digit
            int lastDigit = x % 10;

 //Check for overflow given from the question
            if (reversed > (int.MaxValue - lastDigit)/ 10)
            {
                    Console.WriteLine("The Reversed format is Greater than the Value of the required number");
            }
              //then arrange the reversed number
                reversed = reversed * 10 + lastDigit;
                x /= 10;
           }

            return reversed * sign;
        }
    }
}