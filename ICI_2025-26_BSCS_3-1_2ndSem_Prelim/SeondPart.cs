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

            Student student1;

            student1 = new Student();
            student1.StudentNumber = "2023-0549-IC";
            student1.StudentName = "Mark Joseph A. Flores";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FilipinoHero = "Gen. Antonio Luna";

            Console.WriteLine("Student 1 Number: " + student1.StudentNumber);
            Console.WriteLine("Student 1 Name: " + student1.StudentName);
            Console.WriteLine("Student 1 Course: " + student1.Course);
            Console.WriteLine("Student 1 Year Level: " + student1.YearLevel);
            Console.WriteLine("Student 1 Section: " + student1.Section);
            Console.WriteLine("Student 1 Filipino Hero: " + student1.FilipinoHero);
            Console.WriteLine();

            Student student2;

            student2 = new Student();

            student1 = student2;

            student2.StudentName = "Vincent Josh G. Casuga";
            student2.FilipinoHero = "Dr. Jose Rizal";

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Student 1 Number: " + student1.StudentNumber);
            Console.WriteLine("Student 1 Name: " + student1.StudentName);
            Console.WriteLine("Student 1 Course: " + student1.Course);
            Console.WriteLine("Student 1 Year Level: " + student1.YearLevel);
            Console.WriteLine("Student 1 Section: " + student1.Section);
            Console.WriteLine("Student 1 Filipino Hero: " + student1.FilipinoHero);
            Console.WriteLine();

            Console.WriteLine("Student 2 Number: " + student2.StudentNumber);
            Console.WriteLine("Student 2 Name: " + student2.StudentName);
            Console.WriteLine("Student 2 Course: " + student2.Course);
            Console.WriteLine("Student 2 Year Level: " + student2.YearLevel);
            Console.WriteLine("Student 2 Section: " + student2.Section);
            Console.WriteLine("Student 2 Filipino Hero: " + student2.FilipinoHero);
            Console.WriteLine();
        }
    }

    public class Student
    {
        public string StudentNumber;
        public string StudentName;
        public string Course;
        public int YearLevel;
        public int Section;
        public string FilipinoHero;
    }
}
