namespace CodeChallenge
{
    public class RegularExpressionMatching
    {
        public bool IsMatch(string input, string pattern)
        {
            // Begin matching from the start of both input and pattern
            return MatchHelper(input, pattern, 0, 0);
        }

        private bool MatchHelper(string input, string pattern, int inputIndex, int patternIndex)
        {
            // To Check if we have reached the end of the pattern
            if (patternIndex == pattern.Length)
            {
                // If the pattern is done, check if we've also matched the entire input
                return inputIndex == input.Length;
            }
             // Determine if the current characters in input and pattern match
            bool isCurrentMatch = (inputIndex < input.Length) && 
                                                          (pattern[patternIndex] == input[inputIndex] || pattern[patternIndex] == '.');

            // Handle '*' in the pattern, which matches zero or more of the preceding character
           if (patternIndex + 1 < pattern.Length && pattern[patternIndex + 1] == '*')
           {
            //Then Skip the '*' and move to the next part of the pattern
            //Or  Use '*' to match the current character in the input, if there's a match
                return MatchHelper(input, pattern, inputIndex, patternIndex + 2) ||
                                                                          (isCurrentMatch && MatchHelper(input, pattern, inputIndex + 1, patternIndex));
           } 
           else
           {
                // If there's no '*', move to the next character in both input and pattern if current match is valid
                return isCurrentMatch && MatchHelper(input, pattern, inputIndex + 1, patternIndex + 1);
           }                                  
        }
    }
}