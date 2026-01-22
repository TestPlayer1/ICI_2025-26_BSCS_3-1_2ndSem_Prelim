using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ICI_2025_26_BSCS_3_1_2ndSem_Prelim.SeondPart;

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

            //Put your code here
            Student student1 = new Student();

            student1.studNum = "2023-0464-IC";
            student1.studName = "Shaun Gatchalian";
            student1.course = "BSCS";
            student1.yearLevel = 3;
            student1.section = 1;
            student1.favFilipinoHero = "Andres Bonifacio";

            StudentPrint(student1);
            
            Student student2 = new Student();

            student2 = student1;

            student2.studName = "Saeko Busujima";
            student2.favFilipinoHero = "Jose Rizal";

            StudentPrint(student1);

            Console.WriteLine("Student2 Number: " + student2.studNum);
            Console.WriteLine("Student2 Name: " + student2.studName);
            Console.WriteLine("Student2 Course: " + student2.course);
            Console.WriteLine("Student2: Year Level" + student2.yearLevel);
            Console.WriteLine("Student2 Section: " + student2.section);
            Console.WriteLine("Student2 Favorite Filipino Hero: " + student2.favFilipinoHero);
        }
        private void StudentPrint(Student student1)
        {
            Console.WriteLine("Student1 Number: " + student1.studNum);
            Console.WriteLine("Student1 Name: " + student1.studName);
            Console.WriteLine("Student1 Course: " + student1.course);
            Console.WriteLine("Student1 Year Level: " + student1.yearLevel);
            Console.WriteLine("Student1 Section: " + student1.section);
            Console.WriteLine("Student1 Favorite Filipino Hero: " + student1.favFilipinoHero);
            Console.WriteLine();
        }
        public class Student
        {
            public string studNum;
            public string studName;
            public string course;
            public int yearLevel;
            public int section;
            public string favFilipinoHero;

        }
    }
}
