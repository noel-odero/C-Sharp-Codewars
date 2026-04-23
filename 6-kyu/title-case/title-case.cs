using System;
using System.Linq;
​
public class Kata
{
    public static string TitleCase(string title, string minorWords = "")
    {
        if (string.IsNullOrWhiteSpace(title)) return string.Empty;
​
        var titleArray = title.Split(' ');
        var minorWordsArray = minorWords.Split(' ');
​
        for (int i = 0; i < titleArray.Length; i++)
        {
            if (i == 0)
            {
                titleArray[0] = titleArray[0][0].ToString().ToUpper() + titleArray[0].Substring(1).ToLower();
            }
            else if (minorWordsArray.Contains(titleArray[i], StringComparer.OrdinalIgnoreCase))
            {
                titleArray[i] = titleArray[i].ToLower();
            }
            else
            {
                titleArray[i] = char.ToUpper(titleArray[i][0]) + titleArray[i].Substring(1).ToLower();
            }
        }
​
        return string.Join(' ', titleArray);
    }
}