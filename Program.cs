// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int Test()
{
    var a = 10 + 20;
    var b = a * 2;
    return b;
}

static int TestA()
{
    var c = 10 + 20;
    var d = c * 2;
    return d;
}


System.Console.WriteLine(Test());
System.Console.WriteLine(TestA());
System.Console.WriteLine(Test());