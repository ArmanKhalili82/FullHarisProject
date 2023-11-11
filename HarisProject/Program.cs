using HarisProject.Business;

while (true)
{
    var p = new HarisNumber();

    Console.WriteLine("Enter Your Number:");

    var n = int.Parse(Console.ReadLine()!);
    var str = p.Convert(n);

    Console.WriteLine(str);
}
