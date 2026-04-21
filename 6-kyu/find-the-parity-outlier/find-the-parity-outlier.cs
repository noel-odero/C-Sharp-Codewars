using System;
using System.Linq;
​
public class Kata
{
    public static int Find(int[] integers)
    {
      int evenCount =  integers.Count(x => x % 2 == 0);
      int oddCount = integers.Length - 1;
      
      if(evenCount == 1){
        return integers.First(x => Math.Abs(x) % 2 == 0);
      } else {
        return integers.First(x => Math.Abs(x) % 2 == 1);
      }
      
      
    }
}