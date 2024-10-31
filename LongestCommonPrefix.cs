namespace CodeChallenge
{
    public class LongestCommonPrefix
    {
        public string FindLongestCommonPrefix(string[] strs)
        {
            //When the User input is null or not in araar as required in Q
            if (strs == null || strs.Length == 0)
            {
                Console.WriteLine("Please an array of strings");
            }
            
            //Start with the first string as the initial prefix
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                //while the current string i.e string 2 , does not match the prefix
                while (strs[1].Length < prefix.Length || !strs[i].Substring(0, prefix.Length).Equals(prefix))
                {
                    //Shorten the prefix by one Character
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    
                    //if no common prefix was found
                    if (prefix == "")
                    {
                        Console.WriteLine("No prefix in the Array of stringc inputed");
                    }
                }
                
            }
            return prefix;
        }
    }
}