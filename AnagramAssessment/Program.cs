//Data
using System.Reflection.Metadata;

string[] AOS = { "cook", "save", "aves", "vase", "state", "map" };


//Cara Pertama
var sort = AOS.GroupBy(w => w.WordCount());
Console.WriteLine("Method one Result: \n[");
foreach (var item in sort)
{
    Console.WriteLine($"   [{string.Join(", ", item)}]");
}
Console.WriteLine("]\n");


//Cara Kedua
Dictionary<int, List<string>> group = new Dictionary<int, List<string>>();
foreach (var item in AOS)
{
    try
    {
        group[item.WordCount2()].Add(item);
    }
    catch
    {
        group.Add(item.WordCount2(), new List<string> { item });
    }
}
Console.WriteLine("Method two Result: \n[");
foreach (var item in group)
{
    Console.WriteLine($"   [{string.Join(", ", item.Value)}]");
}
Console.WriteLine("]");

//Method Pendukung
internal static class MyExtensions
{
    //digunakan untuk cara pertama
    public static int WordCount(this string str)
    {
        return str.Sum(x => x);
    }
    //digunakan untuk cara kedua
    public static int WordCount2(this string str)
    {
        int result = 0;
        foreach (int i in str)
            result += i;
        return result;
    }
}
