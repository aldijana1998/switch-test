using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2

{
    class Program
    {
        static void Main(string[] args) {
        switch (args.Length) {
        case 0:
          Console.WriteLine("Nema proslijeđenih argumenata.");
          break;
        case 1:
          Console.WriteLine("Registriran jedan argument.");
          break;
        case 2:
          Console.WriteLine("Registrirana dva argumenta.");
          break;
        case 3:
          Console.WriteLine("Registrirana tri argumenta.");
          break;
        default:
          Console.WriteLine("Registrirana {0} argumenta.");
          break;
            }
        }
    }
}