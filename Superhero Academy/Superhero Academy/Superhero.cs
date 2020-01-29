using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class Superhero
    {
        protected int damage;
        protected int hp;
        protected int stamina;
        protected int randomNumber;
        protected string name;
        protected static Random generator = new Random();
        
        protected virtual void StatGenerator()
        {

        }

        public virtual string CharacterNameChoice(string input)
        {
            name = input;
            Console.WriteLine("Your heros name is: " + name);
            return name;
        }
    


    }
}
