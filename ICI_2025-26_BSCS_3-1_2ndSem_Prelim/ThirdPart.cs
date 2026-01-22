using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{
    class HeroClass
    {
        public int Health;
    }

    struct MinionStruct
    {
        public int Health;
    }

    internal class ThirdPart
    {
        public void Build()
        {
            
            HeroClass myHero = new HeroClass();
            myHero.Health = 100;

            MinionStruct myMinion = new MinionStruct();
            myMinion.Health = 100;

            Console.WriteLine($"Start: Hero Health = {myHero.Health}, Minion Health = {myMinion.Health}");

         
            ApplyDamage(myHero, myMinion);

            Console.WriteLine($"End:   Hero Health = {myHero.Health}, Minion Health = {myMinion.Health}");
        }

        
        public void ApplyDamage(HeroClass h, MinionStruct m)
        {
            h.Health -= 10;
            m.Health -= 10;
        }
    }
}