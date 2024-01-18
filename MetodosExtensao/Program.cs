// See https://aka.ms/new-console-template for more information
using MetodosExtensao;
using System.Text;

Console.WriteLine("Hello, World!");

string strNumber = "123";
string strNumber2 = "";
string strNumber3 = null;

int intNumberConverted = strNumber.ToIntZeroAble();
int intNumberConverted2 = strNumber2.ToIntZeroAble();
int intNumberConverted3 = strNumber3.ToIntZeroAble();



Console.WriteLine(intNumberConverted);
Console.WriteLine(intNumberConverted2);
Console.WriteLine(intNumberConverted3);

int number1 = 1;
object a = null;

string converted1 = number1.ToStringOrEmpty();
string converted2 = a.ToStringOrEmpty();

Console.WriteLine(converted1);
Console.WriteLine(converted2);

string wordLowerExample = "hello world!";
wordLowerExample = wordLowerExample.CapitalizeFirstLetter();

Console.WriteLine(wordLowerExample);

int isNumberEven = 2;
Console.WriteLine(isNumberEven.IsEven());

Console.ReadKey();
