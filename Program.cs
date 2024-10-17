using System;
using CodeChallenge;

int[] nums1 = { 1, 3, 7 };
int[] nums2 = { 2 ,9,10};

MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();

double median = medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);

Console.WriteLine($"The median is: {median}");
