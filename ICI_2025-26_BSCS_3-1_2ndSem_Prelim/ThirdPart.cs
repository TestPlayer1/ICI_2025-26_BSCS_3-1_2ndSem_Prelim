using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{
    internal class ThirdPart
    {
        /*
         The Concept:

        Classes are Reference Types (passing them passes the address).
        Structs are Value Types (passing them passes a copy).

        Requirements: Create a C# Console Application that performs the following:

        Define the Types:
            Create a class named HeroClass with a public integer field called Health.
            Create a struct named MinionStruct with a public integer field called Health.

        Initialize:
            In the Main method, create an object of HeroClass and set its Health to 100.
            In the Main method, create an instance of MinionStruct and set its Health to 100.

        The Method:
            Write a method named ApplyDamage that takes two parameters:
            HeroClass hero

        MinionStruct minion
            Inside the method, subtract 10 from both of their Health values.

        Execute & Observe:
            Call ApplyDamage from Main.
            Print the Health of both units after the method call to see which one actually took damage.
         */



        // TODO 1: Create a Class named 'HeroClass' with a public int Health
        // ____________________
        public class HeroClass
        {
            public int Health;
        }

        // TODO 2: Create a Struct named 'MinionStruct' with a public int Health
        // ____________________
        public struct MinionStruct
        {
            public int Health;
        }


        public void Build()
        {
            // TODO 3: Create instances of both and set Health to 100
            HeroClass myHero = new HeroClass();
            myHero.Health = 100;
           
            MinionStruct myMinion = new MinionStruct();
            myMinion.Health = 100;
           
            Console.WriteLine($"Start: Hero Health = {myHero.Health}, Minion Health = {myMinion.Health}");

            // TODO 4: Call ApplyDamage here
            // ____________________
            ApplyDamage(myHero, myMinion);
           
            Console.WriteLine($"End:   Hero Health = {myHero.Health}, Minion Health = {myMinion.Health}");
        }

        // TODO 5: Write the ApplyDamage method. 
        // It should take (HeroClass h, MinionStruct m) as parameters.
        // It should subtract 10 from the Health of both.
        // ____________________
        public void ApplyDamage(HeroClass h, MinionStruct m)
        {
            int damage = 10;
            h.Health -= damage;
            m.Health -= damage;
        }
    }
}
