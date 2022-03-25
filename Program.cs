using System;
using Jogo_Carrefour_Woman.SRC.Entities;

namespace Jogo_Carrefour_Woman.SRC
{
    class Program 
    
    {
        static void Main (string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Wedge wedge = new Wedge("Wedge", 42, "Ninja");
            Topapa topapa = new Topapa("Topapa", 42, "Black Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(10));
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack(8));
            Console.WriteLine(topapa.Attack(2));

        }
    }
}





