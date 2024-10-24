namespace CodeChallenge
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            // Handle the case where x is negative or if x ends with 0 but is not zero
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                Console.WriteLine("False!! , Number is not Palindrome");
            }
            
            //initialize the num to be reversed
            int reversedNo = 0;

            //Reverse the second half of the number i.e from the back
            while (x > reversedNo)
            {
                reversedNo = reversedNo * 10 + x % 10;
                x /= 10;
            }
            
            //Check if the original number is equal to the reversed number
            //Or if it is equal to the original number after  removing the middle Num (in case of odd Numbers)
            return x == reversedNo || x == reversedNo / 10;
        } 
    }
}