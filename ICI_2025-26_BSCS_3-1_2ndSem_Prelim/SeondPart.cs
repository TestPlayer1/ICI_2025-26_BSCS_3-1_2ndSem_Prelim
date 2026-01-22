using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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

;

            Student student1;
            Student student2;


            student1 = new Student();
            student1.Studentname = "wilson";
            student1.favoritefilipinohero = "rizal";



            student2 = student1;

            Console.WriteLine(student1.Studentname);
            Console.WriteLine(student1.favoritefilipinohero);

            Console.ReadKey();
        }
        public class Student
        {

            public string Studentnumber;
            public string Studentname;
            public string course;
            public int yearlevel;
            public int section;
            public string favoritefilipinohero;

        }






    }
}
