using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy
{
    class IceHero : Superhero
    {
        protected override void StatGenerator()
        {
            randomNumber = generator.Next(10);
            damage = randomNumber - 5;
            randomNumber = generator.Next(10);
            hp = randomNumber + 5;
            randomNumber = generator.Next(10);
            stamina = randomNumber + 3;

        }
        public override string CharacterNameChoice(string input)
        {
            name = input;
            return name;
        }
    }
}
