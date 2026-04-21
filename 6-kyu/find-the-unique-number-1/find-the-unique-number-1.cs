using System.Collections.Generic;
using System.Linq;
​
public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    
    var arr = numbers.ToArray();
    double majority = arr[0] == arr[1] ? arr[0] : arr[2];
    
    
    return arr.First(n => n != majority);
  }
}