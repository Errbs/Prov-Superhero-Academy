using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Superhero h1 = new Superhero();
            Console.WriteLine("Hello, please input a name for your hero.");
            string input = Console.ReadLine();
            h1.CharacterNameChoice(input);
            Console.ReadKey();

        }
    }
}
