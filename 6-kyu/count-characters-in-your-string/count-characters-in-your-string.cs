using System.Collections.Generic;
using System;
​
public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    Dictionary<char, int> count = new Dictionary<char, int>();
    
    foreach(char c in str){
      if(count.ContainsKey(c)){
        count[c]++;
      }
      else{
        count[c] = 1;
      }
    }
    return count;
  }
}