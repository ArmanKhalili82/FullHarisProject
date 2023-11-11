using System.Text;

namespace HarisProject.Business;

public class HarisNumber: HarisToolkit, IHarisNumber
{
    public string Convert(int n)
    {
        var str = new StringBuilder("");

        while (n != 0)
        {
            if (n >= 1 && n < 1000)
            {
                str.Append(OneToHundred(n));
                n = 0;
            }

            if (n >= 1000 &&  n < 1000000)
            {
                str.Append(OneToHundred(n / 1000));
                str.Append(" hezar");
                n = n % 1000;
            }

            if (n >= 1000000 && n < 1000000000)
            {
                str.Append(OneToHundred(n / 1000000));
                str.Append(" milion");
                n = n % 1000000;
            }

            if (n >= 1000000000 && n < 1000000000000)
            {
                str.Append(OneToHundred(n / 1000000000));
                str.Append(" miliard");
                n = n % 1000000000;
            }
        }

        return str.ToString().Trim();
    }
}
