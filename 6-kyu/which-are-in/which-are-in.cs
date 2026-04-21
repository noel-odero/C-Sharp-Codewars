using System.Linq;
​
class WhichAreIn
        {
            public static string[] inArray(string[] array1, string[] array2)
            {
                return array1
                  .Where(a => array2.Any(b => b.Contains(a)))
                  .Distinct()
                  .OrderBy(a => a)
                  .ToArray();
            }
        }