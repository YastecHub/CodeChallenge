namespace CodeChallenge
{
    public class ThreeSumClosestSolver
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            // Sort the array to use the two-pointer technique
            Array.Sort(nums);

            int n = nums.Length;
            int closestSum = int.MaxValue;


            // Loop through each number in the array
            for (int i = 0; i < n - 2; i++)
            {
                int left = i + 1;
                int right = n - 1;


                // Use two pointers to find the best possible sum with nums[i]
                while (left < right)
                {
                    int currentSum = nums[i] + nums[left] + nums[right];
                    
                     // If the currentSum is closer to the target, update closestSum
                    if(Math.Abs(target - currentSum) < Math.Abs(target - closestSum))
                    {
                        closestSum = currentSum;
                    }
                    
                    // Adjust pointers based on the current sum's relation to the target
                    if (currentSum < target)
                    {
                        // Move left pointer right to increase sum
                        left++;
                    }

                    else if (currentSum > target)
                    {
                        // Move right pointer left to decrease sum
                        right--;
                    }

                    else
                    {
                        // If found an exact match, return immediately
                        return currentSum;
                    }
                }
            }
            return closestSum;
        }
    }
}