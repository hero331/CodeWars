/*
https://www.codewars.com/kata/58a6af7e8c08b1e9c40001c1/train/csharp

The hamming distance between a pair of numbers is the number of binary bits that differ in their binary notation.

Example
For a = 25, b = 87, the result should be 4

25: 00011001
87: 01010111
The hamming distance between these two would be 4 ( the 2nd, 5th, 6th, 7th bit ).

Input/Output
[input] integer a
First Number. 1 <= a <= 2^20

[input] integer b
Second Number. 1 <= b <= 2^20

[output] an integer
Hamming Distance
*/
using System;
using System.Linq;
public class HammingDi
{
    public static int HammingDistance(int a, int b) 
    {
        string sa = Convert.ToString(a, 2);
        string sb = Convert.ToString(b, 2);
        sa = (sa.Length>sb.Length ? sa : sa.PadLeft(sb.Length, '0'));
        sb = (sb.Length>sa.Length ? sb : sb.PadLeft(sa.Length, '0'));
        return sa.Where((c, i) => c != sb[i]).Count();
    }
}