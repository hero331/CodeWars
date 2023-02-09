/*
https://www.codewars.com/kata/59a8570b570190d313000037
DESCRIPTION:
Write a function that takes a positive integer n, sums all the cubed values from 1 to n (inclusive), and returns that sum.
Assume that the input n will always be a positive integer.

Examples: (Input --> output)
2 --> 9 (sum of the cubes of 1 and 2 is 1 + 8)
3 --> 36 (sum of the cubes of 1, 2, and 3 is 1 + 8 + 27)
*/

using System;
namespace CodeWars;
public class SumOfCubes
{
    public static long SumCubes(int n)
    {
        long sum = 0;
        for(int i = 1; i <= n; i++){
            sum += (long)Math.Pow(i, 3);
        }
        return sum;
    }
}