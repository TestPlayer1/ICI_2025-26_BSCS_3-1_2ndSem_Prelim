using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{
    /*
    CREATE A STUDENT CLASS WITH THE FOLLOWING PROPERTIES

    STUDENT NUMBER (STRING)
    STUDENT NAME (STRING)
    COURSE (STRING)
    YEAR LEVEL (INTEGER)
    SECTION (INTEGER)
    FAVORITE FILIPINO HERO (STRING)


    create an instance of Student and name it student1;
    assign values to each property of student1;
    print the values of each property to the console in a readable format.

    create another instance of Student and name it student2;
    assign student1 to student2;
    change the Student Name and Favorite Filipino Hero properties of student2 to different values;
    
    print the values of each property of student1 to the console again to observe any changes.
    print the values of each property of student2 to the console to see the updated values.
    
    */

    internal class SeondPart
    {
        public class Student
        {
            public int StudentNumber;
            public string? Name;
            public string? Course;
            public int YearLevel;
            public int Section;
            public string? FavoriteFilipinoLawyear;

        }
        public void Build()
        {
            Console.WriteLine("SECOND PART");

           Student student1 = new Student();
            student1.StudentNumber = 0324;
            student1.Name = "nugget";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoLawyear = "Doc.Jose Rizal ";
            Console.WriteLine($"Student {student1.StudentNumber}");
            Console.WriteLine($"Student {student1.Name}");
            Console.WriteLine($"Student {student1.Course}");
            Console.WriteLine($"Student {student1.YearLevel}");
            Console.WriteLine($"Student {student1.Section}");
            Console.WriteLine($"Student {student1.FavoriteFilipinoLawyear}");
            Console.WriteLine("    ");

            Student student2 = new Student();
            student2.StudentNumber = 0324;
            student2.Name = "midget";
            student2.Course = "BSCS";
            student2.YearLevel = 3;
            student2.Section = 1;
            student2.FavoriteFilipinoLawyear = "Melchora Aquino";

            Console.WriteLine($"Student {student2.StudentNumber}");
            Console.WriteLine($"Student {student2.Name}");
            Console.WriteLine($"Student {student2.Course}");
            Console.WriteLine($"Student {student2.YearLevel}");
            Console.WriteLine($"Student {student2.Section}");
            Console.WriteLine($"Student {student2.FavoriteFilipinoLawyear}");



        }

    }
}
