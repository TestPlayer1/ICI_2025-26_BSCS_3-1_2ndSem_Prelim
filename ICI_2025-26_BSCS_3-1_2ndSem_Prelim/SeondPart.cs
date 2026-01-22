using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ICI_2025_26_BSCS_3_1_2ndSem_Prelim.SeondPart;
using static System.Collections.Specialized.BitVector32;

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



            students student1 = new students();



            student1.StudentNumber = "2025-12345";
            student1. StudentName = "Juan Dela Cruz";
            student1. Course = "BSIS";
            student1. YearLevel = 3;
            student1. Section = 2;
            student1. FavoriteFilipinoHero = "Jose Rizal";


            Console.WriteLine("Student 1 Details:");
            Console.WriteLine($"Student Number: {student1.StudentNumber}");
            Console.WriteLine($"Student Name: {student1.StudentName}");
            Console.WriteLine($"Course: {student1.Course}");
            Console.WriteLine($"Year Level: {student1.YearLevel}");
            Console.WriteLine($"Section: {student1.Section}");
            Console.WriteLine($"Favorite Filipino Hero: {student1.FavoriteFilipinoHero}");
            Console.WriteLine();



            students student2 = new students();



            Console.WriteLine("Student 1 Details:");
            Console.WriteLine($"Student Number: {student1.StudentNumber}");
            Console.WriteLine($"Student Name: {student1.StudentName}");
            Console.WriteLine($"Course: {student1.Course}");
            Console.WriteLine($"Year Level: {student1.YearLevel}");
            Console.WriteLine($"Section: {student1.Section}");
            Console.WriteLine($"Favorite Filipino Hero: {student1.FavoriteFilipinoHero}");
            Console.WriteLine();
       


            student2.StudentNumber = "2026-12345";
            student2.StudentName = "ALING DIANA";
            student2.Course = "TOURSIM";
            student2.YearLevel = 3;
            student2.Section = 2;
            student2.FavoriteFilipinoHero = "DIWATA PARES OVER LOAD";


            students student3 = new students();



            Console.WriteLine("Student 1 Details:");
            Console.WriteLine($"Student Number: {student1.StudentNumber}");
            Console.WriteLine($"Student Name: {student1.StudentName}");
            Console.WriteLine($"Course: {student1.Course}");
            Console.WriteLine($"Year Level: {student1.YearLevel}");
            Console.WriteLine($"Section: {student1.Section}");
            Console.WriteLine($"Favorite Filipino Hero: {student1.FavoriteFilipinoHero}");
            Console.WriteLine();


            student3.StudentNumber = "2025-12345";
            student3.StudentName = "LUFFY";
            student3.Course = "EDUC";
            student3.YearLevel = 3;
            student3.Section = 2;
            student3.FavoriteFilipinoHero = "Andress Bonifacio";


            Console.WriteLine();
            Console.WriteLine();
        


        }

        public class students   
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

