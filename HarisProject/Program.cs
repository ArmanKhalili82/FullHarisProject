using HarisProject.Business;

while (true)
{
    var db = new ApplicationDbContext();

    var p = new HarisNumber();

    Console.WriteLine("Enter Your Number:");

    var n = int.Parse(Console.ReadLine()!);
    var str = p.Convert(n);

    db.stores.Add(new Store() { Number = n, Word = str });
    await db.SaveChangesAsync();

    Console.WriteLine(str);
}
