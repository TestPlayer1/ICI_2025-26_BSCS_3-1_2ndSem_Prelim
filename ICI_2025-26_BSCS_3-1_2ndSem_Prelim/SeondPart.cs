using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ICI_2025_26_BSCS_3_1_2ndSem_Prelim.SeondPart;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Student student2 = new Student();

            //Student 1 Values

            student1.StudentNumber = "2023-0374-IC";
            student1.StudentName = "Patrick Joshua R. Juelar";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoHero ="Heneral Luna";

            student2 = student1;

            // First Output

            Console.WriteLine("Student Number: " + student1.StudentNumber);
            Console.WriteLine("Student Name: " + student1.StudentName);
            Console.WriteLine("Course: " + student1.Course);
            Console.WriteLine("Year Level: " + student1.YearLevel);
            Console.WriteLine("Section: " + student1.Section);
            Console.WriteLine("Favorite Filipino Hero: " + student1.FavoriteFilipinoHero);

            //Space
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            // Second Output
            Console.WriteLine("Student Number: " + student1.StudentNumber);
            Console.WriteLine("Student Name: " + student1.StudentName);
            Console.WriteLine("Course: " + student1.Course);
            Console.WriteLine("Year Level: " + student1.YearLevel);
            Console.WriteLine("Section: " + student1.Section);
            Console.WriteLine("Favorite Filipino Hero: " + student1.FavoriteFilipinoHero);
            Console.WriteLine("Favorite Filipino Hero: " + student2.FavoriteFilipinoHero);

            //Space
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");

            //Student 2 Intialization

            student2.StudentName = "Kiyoshi Kusakabe";
            student2.FavoriteFilipinoHero = "Jose Rizal";

            student1 = student2;    

            // Third Output
            Console.WriteLine("Student Number: " + student1.StudentNumber);
            Console.WriteLine("Student Name: " + student1.StudentName);
            Console.WriteLine("Course: " + student1.Course);
            Console.WriteLine("Year Level: " + student1.YearLevel);
            Console.WriteLine("Section: " + student1.Section);
            Console.WriteLine("Favorite Filipino Hero: " + student1.FavoriteFilipinoHero);
            Console.WriteLine("Favorite Filipino Hero: " + student2.FavoriteFilipinoHero);





        }

        public class Student() 
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
