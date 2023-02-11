// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Diagnostics;
using System.Globalization;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] map1 = {"XOOXO", "XOOXO", "OOOXO", "XXOXO", "OXOOO"};
            Debug.WriteLine($"Result: = {LandPerimeter.Calculate(map1)}");
            string[] map2 = {"XOOOO", "OOOOO", "OOOOO", "OOOOO", "OOOOO"};
            Debug.WriteLine($"Result: = {LandPerimeter.Calculate(map2)}");
            string[] map3 = {"OOOOO", "OOOOO", "OOOOO", "OOOOO", "OOOOO"};
            Debug.WriteLine($"Result: = {LandPerimeter.Calculate(map3)}");
        }
    }
}