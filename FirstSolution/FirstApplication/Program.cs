void PrintName()
{//Method Body
    Console.WriteLine("Hello G3");
}
void PrintAnyName(string name)
{
    Console.WriteLine("Hello " + name);
}
void Greet(string greet)
{
    string name;
    Console.WriteLine("Please enter you name");
    name = Console.ReadLine();
    Console.WriteLine(greet + " " + name);
}
static void Main(string[] args)
{
    Console.WriteLine("Hello World");
    Program program = new Program();
    //program.PrintName();//Method call
    program.Greet("Hi!!!");
    Console.ReadKey();
}