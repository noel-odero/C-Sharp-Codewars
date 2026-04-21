using System.Collections.Generic;
​
​
class WhichAreIn
        {
            public static string[] inArray(string[] array1, string[] array2)
            {
              List<string> result = new List<string>();
              
              foreach(string a in array1){
                foreach(string b in array2){
                  if(b.Contains(a) && !result.Contains(a)){
                    result.Add(a);
                    break;
                  }
                }
                
              }
              
              result.Sort();
              return result.ToArray();
            }
        }