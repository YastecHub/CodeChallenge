using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class FourSumOrderFinder
    {
      public IList<IList<int>> FourSum(int[] nums, int target) {
    //  Sort the array to make it easier to skip duplicates and use the two-pointer approach.
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        
        //Iterate through the array with two nested loops for the first two numbers.
        for (int i = 0; i < nums.Length - 3; i++) 
        {
            // Skip duplicate numbers for the first element
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            for (int j = i + 1; j < nums.Length - 2; j++) 
            {
                // Skip duplicate numbers for the second element
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                
                // Use two pointers to find the remaining two numbers
                int left = j + 1;
                int right = nums.Length - 1;
                
                while (left < right) 
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    
                    if (sum == target) {
                        // If we find a valid quadruplet, add it to the result
                        result.Add(new List<int> 
                        { 
                            nums[i], 
                            nums[j], 
                            nums[left], 
                            nums[right] 
                        });
                        
                        // Move pointers to skip duplicate elements for the third and fourth numbers
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        
                        left++;
                        right--;
                    } else if (sum < target) {
                        // If sum is less than target, move the left pointer to increase the sum
                        left++;
                    } else {
                        // If sum is greater than target, move the right pointer to decrease the sum
                        right--;
                    }
                }
            }
        } 
        return result;
    } }
}