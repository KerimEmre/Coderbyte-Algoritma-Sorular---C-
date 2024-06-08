/*
Longest Word
Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. 
If there are two or more words that are the same length, return the first word from the string with that length.
Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"
*/

using System;
using System.Text.RegularExpressions;

class MainClass {

  public static string LongestWord(string sen) {

    string longWord= "";
    string result = "";
    int longCounter=0;
    int tempCounter=0;
    int indexCounter=0;
    string[] kelimeler = Regex.Split(sen,@"\s");

    
    for(int i=0;i<kelimeler.Length;i++)
    {
      
      for(int j =0;j<kelimeler[i].Length;j++)
      {
         if(char.IsLetterOrDigit(kelimeler[i][j]))
      {
        tempCounter++;
      }
      }
       if(tempCounter>longCounter)
      {
        longCounter=tempCounter;
        longWord = kelimeler[i];
        tempCounter=0;
      }
     
    }

  for(int i=0;i<longWord.Length;i++)
  {
    if(char.IsLetterOrDigit(longWord[i]))
    {
      result += longWord[i];
    }
  }

    return result;

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(LongestWord(Console.ReadLine()));
    
  } 

}