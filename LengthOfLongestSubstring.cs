namespace CodeChallenge
{ 
    public class LengthOfLongestSubstring
    {
        public int FindLengthOfLongestSubstring(string input){
            var charLastSeenAt = new Dictionary<char, int>();
            int maxLength = 0;
            int start = 0;

            for (int end = 0; end < input.Length; end++)
            {
                char currentChar = input[end];

                 if (charLastSeenAt.ContainsKey(currentChar))
                {
                    start = Math.Max(start, charLastSeenAt[currentChar] + 1);
                }

                charLastSeenAt[currentChar] = end;

                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }    
    }
}