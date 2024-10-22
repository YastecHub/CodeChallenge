using System;
using CodeChallenge;
///Q1-Meadian Of Two sorted Arrays
// int[] nums1 = { 1, 3, 7 };
// int[] nums2 = { 2 ,9,10};
// MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
// double median = medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
// Console.WriteLine($"The median is: {median}");


///Q2- Length of Longest SubString
// LengthOfLongestSubstring lengthOfLongestSubstring = new LengthOfLongestSubstring();
 
//  Console.WriteLine("Enter a text to find the longest substring in it");
//  string input = Console.ReadLine();

//  int result = lengthOfLongestSubstring.FindLengthOfLongestSubstring(input);
//  Console.WriteLine($"Length of Longest Substring in the text {input} : {result}");


// ///Q3- Longest Paindrome
//  LongestPalindrome longestPalindrome = new LongestPalindrome();

//  Console.WriteLine("Please enter a string:");
// string input = Console.ReadLine();
// string result = longestPalindrome.FindLongestPalindrome(input);
// Console.WriteLine("The longest palindromic substring is: " + result);

// ///Q4- ZigZagConversion
// ZigZagConversion zigZagConversion = new ZigZagConversion();
// Console.WriteLine("Enter the string to convert in ZigZag pattern");
// string input = Console.ReadLine();

// Console.WriteLine("Enter the Number of rows:");
// int rowInput = int.Parse(Console.ReadLine());   

// string result = zigZagConversion.Convert(input, rowInput);

// Console.WriteLine($"\nString Inputed: {input}");
// Console.WriteLine($"ZigZag Conversion with {rowInput} rows: {result}");

///Q5- Reversing of Interger number
ReverseInteger reverseInteger = new ReverseInteger();
Console.WriteLine("Please enter an integer to be reversed:");
int userInput = int.Parse(Console.ReadLine());

int result = reverseInteger.ReversingOfInteger(userInput);
Console.WriteLine($"Reversed Interger: {result}");