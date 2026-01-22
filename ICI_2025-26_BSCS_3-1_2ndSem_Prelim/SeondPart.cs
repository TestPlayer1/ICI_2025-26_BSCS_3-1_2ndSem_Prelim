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
        }
        //Put your code here

}
     class Student
    {
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }
        public int YearLevel { get; set; }
        public int Section { get; set; }
        public string FavoriteFilipinoHero { get; set; }
    }

    class Programa
    {
        static void PrintStudent(string label, Student s)
        {
            Console.WriteLine(label);
            Console.WriteLine($"Student Number: {s.StudentNumber}");
            Console.WriteLine($"Student Name: {s.StudentName}");
            Console.WriteLine($"Course: {s.Course}");
            Console.WriteLine($"Year Level: {s.YearLevel}");
            Console.WriteLine($"Section: {s.Section}");
            Console.WriteLine($"Favorite Filipino Hero: {s.FavoriteFilipinoHero}");
            Console.WriteLine();
        }

        static void Main()
        {
            
            Student student1 = new Student
            {
                StudentNumber = "2023-0453-IC",
                StudentName = "Fajard, Joseph Emmanuel",
                Course = "BSCS",
                YearLevel = 3,
                Section = 1,
                FavoriteFilipinoHero = "Jose Rizal"
            };

           
            PrintStudent("Student 1", student1);

           
            Student student2 = student1;

         
            student2.StudentName = "Seph Fjardo";
            student2.FavoriteFilipinoHero = "LAPU";

         
            PrintStudent("Student 1", student1);
            PrintStudent("Student 3", student2);
        }
    }
}


