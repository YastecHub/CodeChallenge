using System;
using CodeChallenge;

// int[] nums1 = { 1, 3, 7 };
// int[] nums2 = { 2 ,9,10};
// MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
// double median = medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
// Console.WriteLine($"The median is: {median}");

LengthOfLongestSubstring lengthOfLongestSubstring = new LengthOfLongestSubstring();
 
 Console.WriteLine("Enter a text to find the longest substring in it");
 string input = Console.ReadLine();

 int result = lengthOfLongestSubstring.FindLengthOfLongestSubstring(input);
 Console.WriteLine($"Length of Longest Substring in the text {input} : {result}");
