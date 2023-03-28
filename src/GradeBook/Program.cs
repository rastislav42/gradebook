// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;


var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
grades.Add(56.1);

var result = 0.0;
var devider = grades.Count;
foreach(var number in grades)
{
    result += number;
    
}
result /= grades.Count;
Console.WriteLine($"The averege grade is {result:N1}");


if(args.Length > 0)
{
    Console.WriteLine($"Hello, {args![0]}!");
}
else
{
    Console.WriteLine("Hello !");
}
 