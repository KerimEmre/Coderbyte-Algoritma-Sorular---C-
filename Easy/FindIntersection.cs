/*Find Intersection
Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first 
element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list 
of comma-separated numbers (also sorted). Your goal is to return a comma-separated string containing the numbers that occur in 
elements of strArr in sorted order. If there is no intersection, return the string false.
*/


using System;
using System.Linq;

class MainClass {

  public static string FindIntersection(string[] strArr) {

    string resultString = string.Join(",", strArr[0].Split(',').Select(x => x.Trim()).Intersect(strArr[1].Split(',').Select(x => x.Trim())));
    return string.IsNullOrEmpty(resultString) ? "false" : resultString;

  }

  static void Main() {  

    Console.WriteLine(FindIntersection(Console.ReadLine()));
    
  } 

}