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

    //Student Class
    public class Student
    {
        public string StudentNumber;
        public string Name;
        public string Course;
        public int YearLevel;
        public int Section;
        public string favoriteFilipinoHero;
    }

    internal class SeondPart
    {
        public void Build()
        {
            Console.WriteLine("SECOND PART");

            //Student 1 Initialization
            Student student1 = new Student();
            student1.StudentNumber = "0317";
            student1.Name = "Kyle Renyer";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.favoriteFilipinoHero = "Heneral Luna";

            //Student 1 Info
            Console.WriteLine("STUDENT 1 INFO:");
            Console.WriteLine("Student Student Num: " + student1.StudentNumber);
            Console.WriteLine("Student Name: " + student1.Name);
            Console.WriteLine("Student Course: " + student1.Course);
            Console.WriteLine("Student YearLevel: " + student1.YearLevel);
            Console.WriteLine("Student Section: " + student1.Section);
            Console.WriteLine("Student Favorite Hero: " + student1.favoriteFilipinoHero);

            //Student 2 Initialization
            Student student2 = new Student();
           
            //Assigning Value
            student2 = student1;

            //Change Values of Student 2
            student2.Name = "Trixie";
            student2.favoriteFilipinoHero = "Jose Rizal";

            //Print student 1
            Console.WriteLine("");
            Console.WriteLine("Some Value Changes:");
            Console.WriteLine("Student 1 info:");
            printInfo(student1);

            //Print student 2
            Console.WriteLine("");
            Console.WriteLine("Student 2 info:");
            printInfo(student2);

        }

        public static void printInfo(Student student)
        {
            Console.WriteLine("Student Student Num: " + student.StudentNumber);
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student Course: " + student.Course);
            Console.WriteLine("Student YearLevel: " + student.YearLevel);
            Console.WriteLine("Student Section: " + student.Section);
            Console.WriteLine("Student Favorite Hero: " + student.favoriteFilipinoHero);
        }
    }
}
