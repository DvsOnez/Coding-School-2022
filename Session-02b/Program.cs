// 1 ) 
Console.WriteLine("Hello Dionisis");
//2 ) 
int x = 2;
int y = 3;
int sum = x + y;
double div = (double)x/y;

Console.WriteLine("the sum is :" + sum );
Console.WriteLine("the div is :" + div);

//3 ) 

Console.WriteLine(- 1 + 5 * 6);
Console.WriteLine(14 + ((-3 * 6) / 7));
Console.WriteLine(2 + (13 / 6) * 6 + Math.Sqrt(7));
Console.WriteLine(38+(5 % 7));
Console.WriteLine(((Math.Pow(6, 4) + Math.Pow(5, 7) / (9 % 4))));
//4

int age = 20;
string gender = "Female";
Console.WriteLine($"You are {gender} and you look younger than {age}");

//5 

double seconds = 45678;

Console.WriteLine($"The Minutes are  {(seconds / 60)}  the hours are {(seconds / 3600)} the days are {(seconds / 86400)} and the years are {(seconds / 31536000)}");

//6  

int Seconds = 45678;
TimeSpan Interval = TimeSpan.FromSeconds(Seconds);
Console.WriteLine($"The minutes are {Interval.TotalMinutes} the hours are {Interval.TotalHours} the Days are {Interval.TotalDays} and the Years are {(Interval.TotalDays) / 365} ");

//7 

int celcius = 10;
double fahrenheit = (celcius * (9 / 5) + 32);
double kelvin = (celcius + 273.15);
Console.WriteLine($"The Fahrenheit number is {fahrenheit} The Kelvin number is {kelvin} ");



