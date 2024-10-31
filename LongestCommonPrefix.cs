namespace CodeChallenge
{
    public class LongestCommonPrefix
    {
        public string FindLongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                Console.WriteLine("Please an array of strings");
            }

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[1].Length < prefix.Length || !strs[i].Substring(0, prefix.Length).Equals(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

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