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
            public string StudentNumber { get; set; }
            public string StudentName { get; set; }
            public string Course { get; set; }
            public int YearLevel { get; set; }
            public int Section { get; set; }
            public string FavoriteFilipinoHero { get; set; }
        }
        public void Build()
        {
            Console.WriteLine("SECOND PART");

            Student student1 = new Student();
            Student student2 = new Student();

            student1.StudentNumber = "2023001";
            student1.StudentName = "Juan Dela Cruz";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoHero = "Jose Rizal";

            Console.WriteLine(
                $"Student 1 Details:\n" +
                $"Student Number:           {student1.StudentNumber}\n" +
                $"Student Name:             {student1.StudentName}\n" +
                $"Course:                   {student1.Course}\n" +
                $"Year Level:               {student1.YearLevel}\n" +
                $"Section:                  {student1.Section}\n" +
                $"Favorite Filipino Hero:   {student1.FavoriteFilipinoHero}\n"
            );

            student2 = student1;
            student2.StudentName = "Maria Clara";
            student2.FavoriteFilipinoHero = "Andres Bonifacio";

            Console.WriteLine("-----After modifying student2-----\n");

            Console.WriteLine(
                $"Student 1 Details:\n" +
                $"Student Number:           {student1.StudentNumber}\n" +
                $"Student Name:             {student1.StudentName}\n" +
                $"Course:                   {student1.Course}\n" +
                $"Year Level:               {student1.YearLevel}\n" +
                $"Section:                  {student1.Section}\n" +
                $"Favorite Filipino Hero:   {student1.FavoriteFilipinoHero}\n"
            );

            Console.WriteLine(
                $"Student 2 Details:\n" +
                $"Student Number:           {student2.StudentNumber}\n" +
                $"Student Name:             {student2.StudentName}\n" +
                $"Course:                   {student2.Course}\n" +
                $"Year Level:               {student2.YearLevel}\n" +
                $"Section:                  {student2.Section}\n" +
                $"Favorite Filipino Hero:   {student2.FavoriteFilipinoHero}\n"
            );
        }
    }
}
