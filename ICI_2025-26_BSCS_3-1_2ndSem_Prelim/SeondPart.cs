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

            static void Main(string[] args)
            {
                Student student1;
                Student student2;
                Student student3;

                student1 = new Student();
                student1.StudentNumber = "2023-0461-IC";
                student1.Name = "Jose John Zilian L.";
                student1.Year = "2023-2025";
                student1.Section = "BSCS 3-1";
                student1.FavoriteFilipinoHero = "Dr.Jose Rizal";

                student2 = student1;

                //PRINT
                Console.WriteLine("Student 1 Name " + student1.Name);
                NewMethod(student2);

                student2.Name = "Ruben Ruz";

                Console.WriteLine("Student 1 Name " + student1.Name);
                Console.WriteLine("Student 2 Name " + student2.Name);

                Console.ReadKey();

            }

        private static void NewMethod(Student student2)
        {
            Console.WriteLine("Student 2 Name " + student2.Name);
        }

    }
    public class Student
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public String Section { get; set; }
        public string FavoriteFilipinoHero { get; set; }
    }

        
}

