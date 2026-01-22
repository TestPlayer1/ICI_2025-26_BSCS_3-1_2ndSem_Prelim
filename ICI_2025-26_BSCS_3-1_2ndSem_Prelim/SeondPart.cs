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

            Student student1, student2;
            
            student1 = new Student();
            student1.StudentNumber = "1001";
            student1.StudentName = "Austin Dovrich";
            student1.Course = "Nuclear Engineering";
            student1.YearLevel = 4;
            student1.Section = 1;
            student1.Favourite_Filipino_Hero = "Sarah Duterte";

            Console.WriteLine("Student Number:" + student1.StudentNumber);
            Console.WriteLine("Student Name: " + student1.StudentName);
            Console.WriteLine("Course: " + student1.Course);
            Console.WriteLine("Year Level:" + student1.YearLevel);
            Console.WriteLine("Section: " + student1.Section);
            Console.WriteLine("Favourite Filipino Hero: " + student1.Favourite_Filipino_Hero);

            Console.WriteLine();


            student2 = student1;
            student2.StudentName = "Maximum Intensity X. Larionova";
            student2.Favourite_Filipino_Hero = "Melchora 'Tandang Sora' Aquino";

            Console.WriteLine("student 1");
            Console.WriteLine("Student Number:" + student1.StudentNumber);
            Console.WriteLine("Student Name: " + student1.StudentName);
            Console.WriteLine("Course: " + student1.Course);
            Console.WriteLine("Year Level:" + student1.YearLevel);
            Console.WriteLine("Section: " + student1.Section);
            Console.WriteLine("Favourite Filipino Hero: " + student1.Favourite_Filipino_Hero);

            Console.WriteLine();
            Console.WriteLine("student 2");
            Console.WriteLine("Student Number:" + student2.StudentNumber);
            Console.WriteLine("Student Name: " + student2.StudentName);
            Console.WriteLine("Course: " + student2.Course);
            Console.WriteLine("Year Level:" + student2.YearLevel);
            Console.WriteLine("Section: " + student2.Section);
            Console.WriteLine("Favourite Filipino Hero: " + student2.Favourite_Filipino_Hero);



        }
    }
    public class Student
    {
       public String StudentNumber;
       public String StudentName;
       public String Course;
       public int YearLevel;
       public int Section;
       public String Favourite_Filipino_Hero;
    }

}
