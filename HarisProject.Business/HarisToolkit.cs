using System.Text;

namespace HarisProject.Business;

public class HarisToolkit
{
    private Dictionary<int, string> _numberDic = new Dictionary<int, string>()
    {
        {1, "yek"}, {2, "do"}, {3, "se"}, {4, "chahar"}, {5, "pang"}, {6, "shish"}, {7, "haft"}, {8, "hasht"}, {9, "noh"}, {10, "dah"},
        {11, "yazdah"}, {12, "davazdah"}, {13, "sizdah"}, {14, "chahardah"}, {15, "panzdah"}, {16, "shanzdah"}, {17, "hefdah"}, {18, "hegdah"}, {19, "nozdah"},
        {20, "bist"}, {30, "si"}, {40, "chehel"}, {50, "panjah"}, {60, "shast"}, {70, "haftad"}, {80, "hashtad"}, {90, "navad"},
        {100, "sad"}, {200, "dvist"}, {300, "sisad"}, {400, "chaharsad"}, {500, "pansad"}, {600, "shishsad"}, {700, "haftsad"}, {800, "hashtsad"}, {900, "nohsad"},
    };

    protected string OneToHundred(int n)
    {
        var str = new StringBuilder("");

        while (n != 0)
        {
            if (n >= 1 && n < 20)
            {
                _numberDic.TryGetValue(n, out string value);
                str.Append(" " + value);
                n = 0;
            }

            else if (n >= 20 && n < 99)
            {
                var l = (n / 10) * 10;
                _numberDic.TryGetValue(l, out string value);
                str.Append(" " + value);
                n = n - l;
            }

            else if (n >= 100 && n < 999)
            {
                var l = (n / 100) * 100;
                _numberDic.TryGetValue(l, out string value);
                str.Append(" " + value);
                n = n - l;
            }
        }
        return str.ToString();
    }
}
