/*Console.WriteLine("You need to learn faster");

var testVar = "noob you suck";

Console.WriteLine(testVar);

//Basic datatypes

int digits = 99;
string anything = "abc123";
byte block = 255;
char single = 'a';

Console.WriteLine(digits + anything + single + block);

double testDouble = 0.12;

//add the m,it will give you more precision
decimal testDecimal = 0.12m;

Console.WriteLine(testDecimal + " - " + testDouble);

//modulelus
int remainder = 7 % 5;
Console.WriteLine(remainder);

//remember when you devide
double decimalRetracted = 7.0 / 2;
double decimalNotRetracted = 7 / 2;
Console.WriteLine(decimalNotRetracted + " - " + decimalRetracted);

//+=

int learnInt = 5;
learnInt = learnInt + 1;
learnInt += 5;

Console.WriteLine(learnInt);*/

//Typecasting - converting the datatypes

double x = 0.213456;
int b;

//casting
b =(int)x;
Console.WriteLine(b);

//Convertions from string to int
string value = "123456879";
int result = 0;

if(int.TryParse(value, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure.");
}

