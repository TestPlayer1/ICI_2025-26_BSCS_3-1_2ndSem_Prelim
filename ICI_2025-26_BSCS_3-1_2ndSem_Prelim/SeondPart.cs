using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ICI_2025_26_BSCS_3_1_2ndSem_Prelim.SeondPart;

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

 
            Student student1 = new Student();

            Console.WriteLine("STUDENT 1: ");
            student1.StudentNumber = "001";
            student1.Name = "rassid";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoHero = "Jose Rizal";

   
            Print(student1);

  
            Student student2 = new Student();

            student1 = student2;

            student2.Name = "KYRIE";
            student2.FavoriteFilipinoHero = "LEBRON";

        
            Console.WriteLine("STUDENT 1 : ");
            Print(student1);
            
            Console.WriteLine("STUDENT 2 : ");
            Print(student2);


        }

        private static void Print(Student student)
        {
     
            Console.WriteLine("Student NUMBER. : " + student.StudentNumber);
            Console.WriteLine("Student Name : " + student.Name);
            Console.WriteLine("Student Course : " + student.Course);
            Console.WriteLine("Student Year Level : " + student.YearLevel);
            Console.WriteLine("Student Section: " + student.Section);
            Console.WriteLine("Favorite Filipino Hero : " + student.FavoriteFilipinoHero);

        }

        public class Student
        {
 
            public string StudentNumber;
            public string Name;
            public string Course;
            public int YearLevel;
            public int Section;
            public string FavoriteFilipinoHero;
        }

    }
}
