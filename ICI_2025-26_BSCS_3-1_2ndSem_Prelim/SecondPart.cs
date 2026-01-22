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
            student student1, student2;
            Console.WriteLine("SECOND PART");

            student1 = new student();
            student2 = new student();   

            student1.StudentNumber = "2023-0085-IC";
            student1.StudentName = "Estavillo Richard";
            student1.Course = "BSCS";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.Favhero = "Heneral Luna";

            Console.WriteLine("STUDENT1");
            Console.WriteLine("Student Number:"+ student1.StudentNumber);
            Console.WriteLine("Student Name:" + student1.StudentName);
            Console.WriteLine("Course:" + student1.Course);
            Console.WriteLine("YearLevel:" + student1.YearLevel);
            Console.WriteLine("Section:" +student1.Section);
            Console.WriteLine("Favorite Filipino Hero:" + student1.Favhero);
            

            student2 = student1;
            Console.WriteLine();
            

            student2.StudentNumber = "2023-0087-IC";
            student2.StudentName = "Kurumi Tokisaki";
             

            Console.WriteLine("STUDENT2");
            Console.WriteLine("Student Number:" + student2.StudentNumber);
            Console.WriteLine("Student Name:" + student2.StudentName);
            Console.WriteLine("Course:" + student2.Course);
            Console.WriteLine("YearLevel:" + student2.YearLevel);
            Console.WriteLine("Section:" + student2.Section);
            Console.WriteLine("Favorite Filipino Hero:" + student2.Favhero);



        }

        public class student 
        {
            public string StudentNumber;
            public string StudentName;
            public string Course;
            public int YearLevel;
            public int Section;
            public string Favhero;
        }
         
    }
}
