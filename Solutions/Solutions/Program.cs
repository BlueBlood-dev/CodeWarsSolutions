using System.Linq;
using System.Text;

//https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
string BreakCamelCase(string str)
{
    var builder = new StringBuilder();
    for (int i = 0; i < str.Length; i++)
    {
        builder.Append(str[i]);
        if (i != str.Length - 1)
            if (char.IsUpper(str[i+1]))
                builder.Append(' ');  
    }
    return builder.ToString();
}

Console.WriteLine(BreakCamelCase("CamelCase"));

//https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp
bool IsPangram(string str)
{
    var builder = new StringBuilder();
    builder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
    foreach (char c in str)
        if (builder.ToString().Contains(char.ToUpper(c)))
            builder.Remove(builder.ToString().LastIndexOf(char.ToUpper(c)), 1);
    return builder.ToString().Equals("");
}

Console.WriteLine(IsPangram("abcdefghijklmnopqrstuvwxy"));

//https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
string DuplicateEncode(string word)
{
    var sb = new StringBuilder();
    foreach (char c in word.ToLower())
        if (word.ToLower().Count(symbol => symbol == char.ToLower(c)) > 1)
            sb.Append(')');
        else
            sb.Append('(');
    return sb.ToString();
}

Console.WriteLine(DuplicateEncode("Success"));

//https://www.codewars.com/kata/550554fd08b86f84fe000a58/train/csharp
string[] inArray(string[] array1, string[] array2)
{
    return array1.Distinct().Where(s1 => array2.Any(s2 => s2.Contains(s1))).OrderBy(s => s).ToArray();
}


