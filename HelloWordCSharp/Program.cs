using HelloWordCSharp;

// struct and string interpolation
Point p = new(5, 10);

Console.WriteLine($"Hello, {p}");
Console.WriteLine($"Flipped: {p.Flip()}");


// float and decimal specifiers
var f = 1.12348123048918231983241379127419023740123472f;
var  d = 2000m;
f++;
d++;

Console.WriteLine($"{f} {d}");


// check and uncheck overflow
byte myByte = 255;
unchecked
{ 
    myByte++;
}

Console.WriteLine(Convert.ToDecimal( myByte));


// expression lamda
//Func<int, int> square = x => x * x;
var square = (int x) => x * x;
var readInt = (string s) => int.Parse(s);

Console.WriteLine(square(5));
Console.WriteLine(readInt("5"));


// statement lamda 
var greet = (string name) =>
{
    string greeting = $"Hello {name}!";
    Console.WriteLine(greeting);
};
greet("World");


// record and with keywoard
var myPoint = new NamedPointRecord("Hao", 2, 8);
var myPoint2 = myPoint with { X = 10, Y = 20 };

Console.WriteLine(myPoint.Name);



// pattern matching
var testChar = 'A';

if (testChar is not (>= 'A' and <= 'Z' or >= 'a' and <= 'z' or  '.'))
    Console.WriteLine("true");


// Switch expression
bool IsOneToThree(int n) => n switch
{
    1 => true,
    2 => true,
    3 => true,
    < 1 => false,
    > 3 => false
};

Console.WriteLine(IsOneToThree(0));
Console.WriteLine(IsOneToThree(2));
Console.WriteLine(IsOneToThree(4));


// ??
float? fv;
fv = null;
Console.WriteLine(Tests.SafeTo(fv, -1));
fv = 2.123f;
Console.WriteLine(Tests.SafeTo(fv, -1));

// tuple pattern
Console.WriteLine(Tests.RockPaperScissors("rock", "paper"));
Console.WriteLine(Tests.RockPaperScissors("ROCK", "Paper"));

// await for each
await foreach(int i in Tests.GenerateNumbers(10))
{
    Console.WriteLine(i);
}
