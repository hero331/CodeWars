/*
https://www.codewars.com/kata/5839c48f0cf94640a20001d3/train/csharp

Given an array arr of strings complete the function landPerimeter by calculating the total perimeter of all the islands. Each piece of land will be marked with 'X' while the water fields are represented as 'O'. Consider each tile being a perfect 1 x 1 piece of land. Some examples for better visualization:

['XOOXO',
 'XOOXO',
 'OOOXO',
 'XXOXO',
 'OXOOO'] 
which represents:

should return: "Total land perimeter: 24".

Following input:

['XOOO',
 'XOXO',
 'XOXO',
 'OOXX',
 'OOOO']
which represents:

should return: "Total land perimeter: 18"
*/
public class LandPerimeter
{
    public static string Calculate(string[] map)
    {
        char x = 'X';
        int linksCount = 0;
        int xCount = 0;
        for (int i = 0; i < map.Length; i++){
            for (int j = 0; j < map[i].Length; j++){
                if (map[i][j].CompareTo(x) == 0){
                    xCount++;
                    if (i > 0) if (map[i-1][j] == x) linksCount++;
                    if (i < map.Length-1) if (map[i+1][j] == x) linksCount++;
                    if (j > 0) if (map[i][j-1] == x) linksCount++;
                    if (j < map[i].Length-1) if (map[i][j+1] == x) linksCount++;
                }
            }
        }
        int perimeterTotal = xCount*4 - (linksCount == 0 ? 0 : ((linksCount/2)*2));
        return $"Total land perimeter: {perimeterTotal}";
    }
}