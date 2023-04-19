// See https://aka.ms/new-console-template for more information

using System.Text;
using Strings;

string str = "Atest string";
char c = 'a';

var cArr = str.ToCharArray();

// foreach (var item in cArr)
// {
//     Console.WriteLine(item);
//     Console.WriteLine((int)item);
// }

var split = str.Split(' ');

Console.WriteLine(split.Length);
foreach (var s in split)
{
    Console.WriteLine(s);
}


string str1 = "abc";
string str2 = "deF";

var joined = string.Join("", str2, str1);

Console.WriteLine(joined);
var joined1 = str1 + str2;

Console.WriteLine(joined1);


StringBuilder stringBuilder = new StringBuilder();

stringBuilder.Append(str1);
stringBuilder.Append(str2);

string finalString = stringBuilder.ToString();

var newStr = str.WordCount();