using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
          class Student() {

            public string StudentNumber;
            public string StudentName;
            public string Course;
            public int YearLevel;
            public int Section;
            public string FavoriteFilipinoHero;
        }
        
            public void Build()
            {
                Console.WriteLine("SECOND PART");
                
                 Student student1 = new Student();
                    student1.StudentNumber = "20230553";
                    student1.StudentName = "rea";
                    student1.Course = "BSCS";
                    student1.YearLevel = 3;
                    student1.Section = 1;
                    student1.FavoriteFilipinoHero = "Jose Rizal";
                    Console.WriteLine("Student Name: " +  student1.StudentName);
                    Console.WriteLine("Favorite Filipino Hero: " + student1.FavoriteFilipinoHero);

                    Student student2 = student1;
                    student2.StudentName = "rose";
                    student2.FavoriteFilipinoHero = "Andres Bonifacio";
            Console.WriteLine("Student Name: " + student2.StudentName);
            Console.WriteLine("Favorite Filipino Hero: " + student2.FavoriteFilipinoHero);




        }
        }
    }
