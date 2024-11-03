namespace CodeChallenge
{
    public class UniqueTripletSumFinder
    {
       public IList<IList<int>> ThreeSumFinder(int[] nums)
       {
        // To store the unique triplets that sum up to zero
        var result = new List<IList<int>>();
         
         //Sort the array 
         Array.Sort(nums);
         
         //To Iterate through each number in the sorted array
         for (int i = 0; i < nums.Length -2; i++)
         {
            // Skip duplicate elements for the first position to avoid duplicate triplets
            if (i > 0 && nums[i] == nums[i - 1])
             continue;


            // Initialize two pointers, one just after the current element and one at the end of the array
             int left = i + 1;
             int right = nums.Length - 1;


            //Then Use the two-pointer approach to find the remaining two numbers
             while (left < right)
             {
                 // Calculate the sum of the current triplet
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                     // Found a valid triplet, add it to the result list
                    result.Add(new List<int>
                    {
                      nums[i],
                      nums[left],
                      nums[right]
                    });
                   

                    // Move the left pointer to the right while skipping duplicate values
                    while (left < right && nums[right] == nums[left - 1])
                        left++;
                    left++;


                    // Move the right pointer to the left while skipping duplicate values
                    while (left < right && nums[right] == nums[right - 1])
                        right--;
                    right--;
                }
                else if (sum < 0)
                {
                   // If the sum is too low, move the left pointer to increase the sum
                    left++;
                }
                else
                {
                    // If the sum is too high, move the right pointer to decrease the sum
                    right--;
                }
             }
         }
         return result;
       }
    
    }
}