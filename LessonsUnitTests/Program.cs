// See https://aka.ms/new-console-template for more information
using LessonsUnitTests;

Console.WriteLine("Hello, World!");

long? pResult = null;

var phone = new NumberPhone();
var res = phone.GetNumber("8 999 999 99 99", out pResult);

Console.WriteLine(res);