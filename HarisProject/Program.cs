using HarisProject.Business;
using Microsoft.EntityFrameworkCore;

var db = new ApplicationDbContext();

while (true)
{
    var p = new HarisNumber();

    Console.WriteLine("Enter Your Number:");

    var n = int.Parse(Console.ReadLine()!);
    var str = p.Convert(n);

    var store = await db.stores.Where(s => s.Number == n).FirstOrDefaultAsync();
    if (store == null)
    {
        db.stores.Add(new Store() { Number = n, Word = str });
        await db.SaveChangesAsync();
    }

    //db.stores.Add(new Store() { Number = n, Word = str });
    

    Console.WriteLine(str);
}
