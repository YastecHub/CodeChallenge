namespace CodeChallenge 
{
        public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] num1, int[] num2)
        {
            int m = num1.Length;
            int n = num2.Length;
            int[] mergedNumbers = new int[m + n];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < m && j < n)
            {
                if (num1[i] < num2[j])
                {
                    mergedNumbers[k++] = num1[i++];
                }
                else
                {
                    mergedNumbers[k++] = num2[j++];
                }
            }

            while (i < m)
            {
                mergedNumbers[k++] = num1[i++];
            }

            while (j < n)
            {
                mergedNumbers[k++] = num2[j++];
            }

            int totalLength = m + n;
            if (totalLength % 2 == 1)
            {
                return mergedNumbers[totalLength / 2];
            }
            else
            {
                int mid1 = totalLength / 2;
                int mid2 = mid1 - 1;
                return (mergedNumbers[mid1] + mergedNumbers[mid2]) / 2;
            }
        }
    }
}