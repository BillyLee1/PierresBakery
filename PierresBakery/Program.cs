using System;
using Breads.Models;
using Pastrys.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("We sell bread for 5 dollars a loaf and we have a buy two get one deal.");
      Console.WriteLine("We also sell pasteries for 2 dollars each and we have a buy three get one deal.");
      Console.WriteLine("How many loafs of bread would you like to purchase?");
      string BreadString = Console.ReadLine();
      Console.WriteLine("How many pasteries would you like to purchase?");
      string PastryString = Console.ReadLine();
      int BreadCt = int.Parse(BreadString);
      int PastryCt = int.Parse(PastryString);
      Bread breadClass = new Bread(BreadCt);
      Pastry pastryClass = new Pastry(PastryCt);
      Console.WriteLine("############################################################################");
      Console.WriteLine("----------------------------------------------------------------------------");
      Console.WriteLine($"You bought {BreadString} loafs of bread and");
      CheckBreadCost(breadClass);
      Console.WriteLine("                                  ████████████████                      ");
      Console.WriteLine("                              ██████░░░░░░████░░░░██  ████                 ");
      Console.WriteLine("                          ████░░░░████░░░░░░██░░░░░░██░░░░██              ");
      Console.WriteLine("                        ██░░░░░░░░░░██░░░░░░██░░░░░░░░██░░░░██  ");
      Console.WriteLine("                        ██░░░░░░░░░░██░░░░░░░░░░░░░░░░██░░░░░░██  ");
      Console.WriteLine("                      ██▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓██ ");
      Console.WriteLine("                      ██▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓██");
      Console.WriteLine("                      ██▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓██  ");
      Console.WriteLine("                        ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████");
      Console.WriteLine("                            ██████████████████████████  ");
      Console.WriteLine("----------------------------------------------------------------------------");
      Console.WriteLine($"You bought {PastryString} pastries and");
      CheckPastryCost(pastryClass);
      Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("                    ▒▒▒▒▒▒▒▒                    ");
Console.WriteLine("                  ▒▒▒▒▒▒░░▒▒▒▒  ");
Console.WriteLine("                  ▒▒░░░░▒▒▒▒▒▒ ");
Console.WriteLine("              ░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░  ");
Console.WriteLine("            ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░  ");
Console.WriteLine("            ▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒ ");
Console.WriteLine("        ▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒   ");
Console.WriteLine("      ▓▓░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░░░▒▒ ");
Console.WriteLine("    ▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒░░ ");
Console.WriteLine("    ▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒");
Console.WriteLine("    ▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒");
Console.WriteLine("    ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
Console.WriteLine("      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ");
Console.WriteLine("          ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
      Console.WriteLine("###########################################################################");
    }

    static void CheckBreadCost(Bread breadClass)
    {
      string result = breadClass.CheckCost();
      Console.WriteLine($"it costed you ${result}.");
    }

    static void CheckPastryCost(Pastry pastryClass)
    {
      string result = pastryClass.CheckCost();
      Console.WriteLine($"it costed you ${result}.");
    }
  }
}
