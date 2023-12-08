using System.Text.RegularExpressions;

var file = File.ReadAllLines(@"input.txt");
var regex = new Regex(@"\D");

int[] allNrs = file.Select(x =>
{
    Console.WriteLine(x);
    x = x.Replace("nine", "n9e");
    x = x.Replace("eight", "e8t");
    x = x.Replace("seven", "s7n");
    x = x.Replace("six", "s6x");
    x = x.Replace("five", "f5e");
    x = x.Replace("four", "f4r");
    x = x.Replace("three", "t3e");
    x = x.Replace("two", "t2o");
    x = x.Replace("one", "o1e");


    string nrs = regex.Replace(x, "");
    
    Console.WriteLine(nrs);
    if (nrs.Count() == 1)
    {
        return int.Parse(nrs.First().ToString() + nrs.First().ToString());
    }
    return int.Parse(nrs.First().ToString() + nrs.Last().ToString());
}).ToArray();

Console.WriteLine(allNrs.Sum());
