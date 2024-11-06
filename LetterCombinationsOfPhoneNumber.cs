namespace CodeChallenge
{
    public class LetterCombinationsOfPhoneNumber
    {
        // Created a mapping of digits to letters as a dictionary.
        public static readonly Dictionary<char, string> phoneMap = new Dictionary<char, string>
        {
            { '2', "abc" }, { '3', "def" },
            { '4', "ghi" }, { '5', "jkl" },
            { '6', "mno" }, { '7', "pqrs" },
            { '8', "tuv" }, { '9', "wxyz" }
        };


        public IList<string> LetterCombinations(string digits)
        {
            //Handle cases where input is empty.
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            
            //Defining a list to hold the results
            List<string> results = new List<string>();


            //Call the recursive function to start building combinations.
            GenerateCombinations(0, digits, "", results);

            return results;
        }

        // Recursive helper function to generate combinations.
        private void GenerateCombinations(int index, string digits, string currentCombination, List<string> results)
        {
           //If the current combination length equals digits length, add to results.
           if (index == digits.Length)
           {
                results.Add(currentCombination);
                return;
           }
           
           // Get the letters mapped to the current digit.
           char digit = digits[index];
           string letters = phoneMap[digit];

           //Loop through each letter mapped to this digit.
           foreach (char letter in letters)
           {
                //Move to the next digit, add the current letter to the combination.
                GenerateCombinations(index + 1, digits, currentCombination + letter, results);
           }
        }
    }
}