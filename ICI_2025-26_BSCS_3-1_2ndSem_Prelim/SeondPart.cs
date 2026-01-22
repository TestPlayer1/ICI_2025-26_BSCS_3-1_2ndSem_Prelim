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
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("                                  SECOND PART                                      ");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            //
            //object declare
            Student student1 = new Student();


            // student 1
            student1.studentNumber = "2023-0067-IC";
            student1.name = "Ragasa Kurt.";
            student1.course = "BSCS";
            student1.yearLevel = 3;
            student1.section = 1;
            student1.favoriteFilipinoHero = "Goyo";

            //student 2
            Student student2 = new Student();
            student2 = student1;

            Console.WriteLine("Student 1: " + student1.studentNumber + " " + student1.name + " " + student1.course + " " + student1.yearLevel + " - " + student1.section + " " + student1.favoriteFilipinoHero);
            Console.WriteLine("Student 2: " + student2.studentNumber + " " + student2.name + " " + student2.course + " " + student2.yearLevel + " - " + student2.section + " " + student2.favoriteFilipinoHero);

            // change value
            Console.WriteLine("");
            student2.name = "Bryan";
            student2.favoriteFilipinoHero = "Andress Bonificio";
            Console.WriteLine("Student 1: " + student1.studentNumber + " " + student1.name + " " + student1.course + " " + student1.yearLevel + " - " + student1.section + " " + student1.favoriteFilipinoHero);
            Console.WriteLine("Student 2: " + student2.studentNumber + " " + student2.name + " " + student2.course + " " + student2.yearLevel + " - " + student2.section + " " + student2.favoriteFilipinoHero);




        }
        //public class Stud

    }
   
    // Class
    public class Student
    {
        public string studentNumber;
        public string name;
        public string course;
        public int yearLevel;
        public int section;
        public string favoriteFilipinoHero;
    }
}
