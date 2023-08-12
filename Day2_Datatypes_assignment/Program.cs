// implicit conversions

int num = 10;
decimal d1 = num;
Console.WriteLine(d1);

int num1 = 20;
float d2 = num1 * 10;
Console.WriteLine(d2);

float num2 = 10.02f;
double d3 = num2;
Console.WriteLine(d3);  

char char1 = 'a';
int char2 = char1;
Console.WriteLine(char2);

byte byte1 = 112;
int intval1 = byte1;
Console.WriteLine(intval1);

//explicit conversion examples

double val1 = 3.14;
int intval = (int)val1;
Console.WriteLine(intval);

long long1 = 1000;
int int1 =(int)long1;
Console.WriteLine(int1);

float intv1 = 233.89f;
int value1 = (int)intv1;
Console.WriteLine(value1);
