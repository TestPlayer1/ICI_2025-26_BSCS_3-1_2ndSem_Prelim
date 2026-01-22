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
        public void Build()
        {
            Console.WriteLine("SECOND PART");

            //Put your code here
            Student student1;
            Student student2;
            Student student3;

            student1 = new Student();
            student1.StudentNumber = 359;
            student1.Name = "Rico";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoHero = "Jose Rizal";

            Console.WriteLine("Student1: " + student1.Name);
            Console.WriteLine("Student1: " + student1.FavoriteFilipinoHero);
            Console.WriteLine("Student1: " + student1.StudentNumber);
            Console.WriteLine("Student1: " + student1.Course);
            Console.WriteLine("Student1: " + student1.YearLevel);
            Console.WriteLine("Student1: " + student1.Section);

            student2 = student1;

            student2.Name = "King";
            student2.FavoriteFilipinoHero = "Lapu-Lapu";

            Console.WriteLine("Student2: " + student2.Name);
            Console.WriteLine("Student2: " + student2.FavoriteFilipinoHero);
            Console.WriteLine("Student2: " + student2.StudentNumber);
            Console.WriteLine("Student2: " + student2.Course);
            Console.WriteLine("Student2: " + student2.YearLevel);
            Console.WriteLine("Student2: " + student2.Section);
        }

        public class Student
        {
            public int StudentNumber;
            public string Name;
            public string Course;
            public int YearLevel;
            public int Section;
            public string FavoriteFilipinoHero;
        }
    }
}
