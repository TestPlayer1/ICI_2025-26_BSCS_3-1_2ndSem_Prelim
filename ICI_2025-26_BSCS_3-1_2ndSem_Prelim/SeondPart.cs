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
    

            Student student1;
            Student student2;

            student1 = new Student();
            student1.StudentName = "Mark Edsel";
            

            student1.StudentNumber = "2024-0457";
            student1.StudentName = "Mark Edsel Dela Cruz";
            student1.Year = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoHero = "Lapu Lapu";

            student2 = student1;

            Console.WriteLine(student1.StudentName);
           


       
            Console.ReadKey();
        }
    }

    public class Student
    {
        public string StudentNumber;
        public string StudentName;
        public int Year;
        public int Section;
        public string FavoriteFilipinoHero;
    }
}
