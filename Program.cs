// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------


using System.Diagnostics;

namespace Hagman_Game
{
  class Program
  {
    public static string message = "Salom";
    public static bool isTrue = true;
    public static int count = 0;

    public static void Main(string[] args)
    {
      string charrectr = string.Empty;
      Console.Clear();
      System.Console.WriteLine("Welcome to, my project");
      System.Console.WriteLine("Siz (------) ortida yashiringan so'zni topishga harakat qiling");
      System.Console.WriteLine("Eslatma: Ushbu uyinda ingiliz tilini bilish talab qilinadi");
      condition:
      if(isTrue)
      {
        System.Console.Write("Belgini kiriting: ");
        charrectr = Console.ReadLine();
        GetVersions(out string result, charrectr);
      }
      else
      {
        System.Console.WriteLine(" ==== Topolmadingiz :( ===== ");
        isTrue = true;
      }
      goto condition;


    }
    static void GetVersions(out string result, string charrectr)
    {
      result = string.Empty;
      int countLocal = count;
      string[,] messagess =
      {
        {"a", "🐜(chumoli)"},
        {"b", "🐻(ayiq)"},
        {"c", "🚘(moshina)"},
        {"d", "🦮(it)"},
        {"e", "🐘(fil)"},
        {"f", "🐟(baliq)"},
        {"g", "🐐(echki)"},
        {"h", "🐎(ot)"},
        {"i", "Hind"},
        {"j", "Yaguar"},
        {"k", "🦘(kengiru)"},
        {"l", "🦁(gepard)"},
        {"m", "🐒(maymun)"},
        {"n", "yo'q"},
        {"o", "ochiq"},
        {"p", "🐼(panda)"},
        {"q", "savol"},
        {"r", "🐇(quyon)"},
        {"s", "kechirasiz"},
        {"t", "rahmat"},
        {"u", "ukraina"},
        {"v", "qiymat"},
        {"w", "🐺(bo'ri)"},
        {"x", ""},
        {"y", ""},
        {"z", "🦓(zebra)"}
      };

     if(charrectr.ToString().ToLower().Contains(message[0].ToString().ToLower()))
     {

        for(int i = 0; i < messagess.Length / 2; i++)
        {
            if(messagess[i, 0].Contains(message[0].ToString().ToLower()))
            {
              // System.Console.WriteLine("Topdingiz !");
              // System.Console.WriteLine($"{charrectr}");
              result = messagess[i, 1];
              message = message.Substring(1, message.Length - 1);
              count++;
              System.Console.WriteLine($"{count} - harif ingiliz tilda {result} ning birinchi harifi");
              break;

            }

        }
        if(countLocal == count)
          isTrue = false;
     }
     else if(count == 0)
     {
      for(int i = 0; i < messagess.Length / 2; i++)
        {
            if(messagess[i, 0].Contains(message[0].ToString().ToLower()))
            {
              result = messagess[i, 1];
              message = message.Substring(1, message.Length - 1);
              count++;
              break;

            }

        }

     }


    }
  }


}
