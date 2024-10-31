using System;
using CodeChallenge;
////Q1-Meadian Of Two sorted Arrays
// int[] nums1 = { 1, 3, 7 };
// int[] nums2 = { 2 ,9,10};
// MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
// double median = medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
// Console.WriteLine($"The median is: {median}");


////Q2- Length of Longest SubString
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


// ///Q5- Reversing of Interger number
// ReverseInteger reverseInteger = new ReverseInteger();
// Console.WriteLine("Please enter an integer to be reversed:");
// int userInput = int.Parse(Console.ReadLine());
// int result = reverseInteger.ReversingOfInteger(userInput);
// Console.WriteLine($"Reversed Interger: {result}");

// ////Q6- Converting String Input to Interger
// ConvertStringToInteger convertStringToInteger = new ConvertStringToInteger();
// Console.WriteLine("Please enter the the string needed to be converted to interger");
// string userInputed = Console.ReadLine();
// int result = convertStringToInteger.ConvertingStringToInteger(userInputed);
// Console.WriteLine($"The Converted integer is: {result}");

////Q7 Palindrome Of Numbers
// PalindromeNumber palindromeNumber = new PalindromeNumber();
// Console.WriteLine("Enter a number to check if it's a palindrome:");
// int number = int.Parse(Console.ReadLine());
// bool resultOfPalindrome = palindromeNumber.IsPalindrome(number);
// if (resultOfPalindrome)
// {
//     Console.WriteLine($"{number} is a palindrome!");
// }
// else
// {
//     Console.WriteLine($"{number} is not a palindrome.");
// }


// ///Q8--Regular Expression Matching
// Console.WriteLine("Enter the input string:");
// string input = Console.ReadLine();
// Console.WriteLine("Enter the pattern:");
// string pattern = Console.ReadLine();
// RegularExpressionMatching regexxMatcher = new RegularExpressionMatching();
// bool IsMatch = regexxMatcher.IsMatch(input, pattern);
// Console.WriteLine($"Does the input match the pattern? {IsMatch}");


// ////Q9-- Finding Container With Most Water
// Console.WriteLine("Please Enter the container Heights separated by spaces");
// string input = Console.ReadLine();
// int[] height = Array.ConvertAll(input.Split(), int.Parse);
// ContainerWithMostWater containerWithMostWater= new ContainerWithMostWater();
// int maxWaterArea = containerWithMostWater.FindMaxArea(height);
// Console.WriteLine($"The Maximum area of water the container can hold is: {maxWaterArea}");


// //// Q10 Converting Integer to Roman Numerals
// Console.WriteLine("Please Enter the Number to be converted to its Roman Numerals");
// int num = int.Parse(Console.ReadLine());
// ConvertIntegerToRoman convertIntegerToRoman = new ConvertIntegerToRoman();
// string romanNumeral = convertIntegerToRoman.IntToRoman(num);
// Console.WriteLine($"The Roman numeral for {num} is: {romanNumeral}");


///Q11 Converting Roman Numerals to integer
Console.WriteLine("Please Enter a Roman numeral to be converted to an integer:");
string input = Console.ReadLine();

RomanToIntegerConverter romanToIntegerConverter = new RomanToIntegerConverter();
int result = romanToIntegerConverter.RomanToInt(input.ToUpper());

Console.WriteLine($"The integer value of {input} is: {result}");

