namespace CodeChallenge
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                Console.WriteLine("False!! , Number is not Palindrome");
            }

            int reversedHalf = 0;

            while (x > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + x % 10;
                x /= 10;
            }

            return x == reversedHalf || x == reversedHalf / 10;
        } 
    }
}