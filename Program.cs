// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------


using System.Diagnostics;

namespace Hagman_Game
{
  class Program
  {
      public static string[,] messagess =
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
        {"x", "x"},
        {"y", "ha"},
        {"z", "🦓(zebra)"}
      };

    public static string message = "Nima";
    public static string newMessage = string.Empty;
    public static bool isTrue = true;
    public static int count = 1;
    public static int countP = 0;
    public static int messageCount = message.Length;
    public static string result = string.Empty;


    public static void Main(string[] args)
    {
      string charrectr = message[0].ToString().ToLower();
      Console.Clear();
      System.Console.WriteLine("Welcome to, my project");
      System.Console.WriteLine($"Siz (------) ortida yashiringan \"{message.Length}\" ta harifdan tashkiltopgan so'zni topishga harakat qiling");
      System.Console.WriteLine("Eslatma: Ushbu uyinda ingiliz tilini bilish talab qilinadi");

      GetReselt(charrectr);
      System.Console.WriteLine($"{count} - harif ingiliz tilda \"{result}\" so'zining birinchi harifi");
      gotoGame:
      if(message != null && countP != 3)
      {

        System.Console.Write("Harifni kiriting: ");
        charrectr = Console.ReadLine();
        GetVersions(charrectr);
        GetReselt1();

        if(isTrue == true)
        {
          newMessage += charrectr;
          System.Console.WriteLine("Topdingiz !");
          System.Console.WriteLine($"{newMessage}---");
          System.Console.WriteLine("=============================");
          if(newMessage.Length == messageCount)
          {
            countP = 3;

          }
          else{
            System.Console.WriteLine($"{count} - harif ingiliz tilda \"{result}\" so'zining birinchi harifi");
          }
          goto gotoGame;
        }
        else
        {
          System.Console.WriteLine("Topolmadigiz !");
          countP++;
          goto gotoGame;

        }

      }
      else
      {
        System.Console.WriteLine("O'yin tugandi !!! ");

      }




    }
    static void GetVersions(string? charrectr)
    {

     if(charrectr.ToString().ToLower().Contains(message[0].ToString().ToLower()))
     {

        for(int i = 0; i < messagess.Length / 2; i++)
        {
            if(messagess[i, 0].Contains(charrectr.ToString().ToLower()))
            {
              isTrue = true;
              if(message.Length  != 1)
              {
                message = message.Substring(1, message.Length - 1);

              }
              count++;
              break;

            }

        }
     }
     else
      isTrue = false;
    }

    static void GetReselt(string? charrectr)
    {

        for(int i = 0; i < messagess.Length / 2; i++)
        {
            if(messagess[i, 0].Contains(charrectr.ToString().ToLower()))
            {
              result = messagess[i, 1];
              break;

            }

        }
    }

    static void GetReselt1()
    {

        for(int i = 0; i < messagess.Length / 2; i++)
        {
            if(messagess[i, 0].Contains(message[0].ToString().ToLower()))
            {
              result = messagess[i, 1];
              break;

            }

        }
    }

  }


}
