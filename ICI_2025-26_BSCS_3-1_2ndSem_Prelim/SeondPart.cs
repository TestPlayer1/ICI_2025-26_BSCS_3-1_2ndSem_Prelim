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

    internal class Student
    {
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }
        public int YearLevel { get; set; }
        public int Section { get; set; }
        public string FavoriteFilipinoHero { get; set; }
    }

    internal class SecondPart
    {
        public void Build()
        {
            // Create student1 and assign values
            Student student1 = new Student
            {
                StudentNumber = "2023-0526-IC",
                StudentName = "Roel Dela Cruz Jr",
                Course = "BSCS",
                YearLevel = 3,
                Section = 1,
                FavoriteFilipinoHero = "Antonio Luna"
            };

            Console.WriteLine("STUDENT 1 DETAILS");
            PrintStudent(student1);

            // Assign student1 to student2
            Student student2 = student1;

            // Modify student2 properties
            student2.StudentName = "ELIJAH DELA CRUZ";
            student2.FavoriteFilipinoHero = "Jose Rizal";

            Console.WriteLine("\nSTUDENT 1 DETAILS AFTER CHANGES");
            PrintStudent(student1);

            Console.WriteLine("\nSTUDENT 2 DETAILS");
            PrintStudent(student2);
        }

        private void PrintStudent(Student student)
        {
            Console.WriteLine($"Student Number: {student.StudentNumber}");
            Console.WriteLine($"Name: {student.StudentName}");
            Console.WriteLine($"Course: {student.Course}");
            Console.WriteLine($"Year Level: {student.YearLevel}");
            Console.WriteLine($"Section: {student.Section}");
            Console.WriteLine($"Favorite Filipino Hero: {student.FavoriteFilipinoHero}");
        }

    }
}