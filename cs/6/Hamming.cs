/*
https://www.codewars.com/kata/5410c0e6a0e736cf5b000e69/train/csharp

The Hamming Distance is a measure of similarity between two strings of equal length. Complete the function so that it returns the number of positions where the input strings do not match.

Examples:
a = "I like turtles"
b = "I like turkeys"
Result: 3

a = "Hello World"
b = "Hello World"
Result: 0

a = "espresso"
b = "Expresso"
Result: 2
You can assume that the two input strings are of equal length.
*/
using System;

public class Hamming
{
	public static int Distance(string a, string b)
	{
        int c = 0;
		for (int i=0;i<a.Length;i++){
            if (a[i] != b[i]) c++;
        }
        return c;
	}
}