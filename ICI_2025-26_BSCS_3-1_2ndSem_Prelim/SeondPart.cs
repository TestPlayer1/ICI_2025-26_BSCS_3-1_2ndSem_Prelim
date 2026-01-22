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
            Console.WriteLine("SECOND PART\n");

            Student student1 = new Student();                                   // Details
            student1.StudentNumber = "2023-0175-IC";
            student1.StudentName = "Quine, Mark Rainer Dion DG.";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoHero = "Andres Bonifacio";

            Console.WriteLine("Student 1 Details:");                           // Student 1 Details 
            PrintStudent(student1);

            Student student2 = student1;  

            student2.StudentName = "Kobe";                                     // Student 2 Details
            student2.FavoriteFilipinoHero = "Juan Luna";                       

            Console.WriteLine("\nStudent 1 Details After Changes:");
            PrintStudent(student1);

            Console.WriteLine("\nStudent 2 Details:");
            PrintStudent(student2);
        }

        void PrintStudent(Student s)                                           // Print
        {
            Console.WriteLine($"Student Number: {s.StudentNumber}");
            Console.WriteLine($"Student Name: {s.StudentName}");
            Console.WriteLine($"Course: {s.Course}");
            Console.WriteLine($"Year Level: {s.YearLevel}");
            Console.WriteLine($"Section: {s.Section}");
            Console.WriteLine($"Favorite Filipino Hero: {s.FavoriteFilipinoHero}");
        }
        class Student                                                          // Classes
        {
            public string StudentNumber;
            public string StudentName;
            public string Course;
            public int YearLevel;
            public int Section;
            public string FavoriteFilipinoHero;
        }
    }
}


   
