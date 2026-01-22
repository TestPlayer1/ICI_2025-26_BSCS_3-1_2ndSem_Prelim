using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

            student1 = new Student();
            student1.StudentNumber = "2023-1501-IC";
            student1.StudentName = "Rimuru Lee";
            student1.Course = "BSIS";
            student1.YearLevel = 1;
            student1.Section = 1;
            student1.FavFilHero = "ANTONIO LUNA";

            Console.WriteLine($"Student{student1.StudentNumber}");
            Console.WriteLine($"Student{student1.StudentNumber}");
        }
        public class Student
        {

            public string StudentNumber { get; set; }
            public string StudentName { get; set; }

            public string  Course { get; set; }
            public int YearLevel { get; set; }
            public int Section {  get; set; }
            public string FavFilHero { get; set; }


         
            
        }    
      
    }

}


