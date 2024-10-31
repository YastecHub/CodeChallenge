namespace CodeChallenge
{
    public class RomanToIntegerConverter
    {
        public int RomanToInt(string s)
        {
            //Used Dictionary to store the pre defined Values in RomanNumerals
            Dictionary<char, int> romanMap = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };
             
            //Used to keep the result 
            int result = 0;

            
            for (int i = 0; i < s.Length; i++)
            {
                //Condition to check if the Roman Numral input by user is of Two index or more 
                if (i < s.Length -1 &&  romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    //Substract if the first index is greater than the later
                    result -= romanMap[s[i]];
                }
                else
                {
                    //Or else Add thenm together
                    result += romanMap[s[i]];
                }
            }
            return result;
        }
    }
}