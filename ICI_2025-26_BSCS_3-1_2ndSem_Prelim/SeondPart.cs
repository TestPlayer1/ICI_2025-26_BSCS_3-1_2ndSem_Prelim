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

            static void Main(StringSplitOptions[] args)
            {
                Student student1;
                Student student2;
                Student Student3;

                student1= new Student();
                student1.Student Number = "2023-0848-IC";
                student1.YearLevel = "2023-2025";
                student1.section = "BSCS 3-1";
                student1.FavoriteFilipinoHero = "ANTONIO LUNA";


                student2 = student1;
                //PRINT
                Console.WriteLine('student 1 Name ')






            }



        public string Studentnumber { get; set; }

        public string StudentName { get; set; }

        public string YearLevel { get; set; }

        public string Section { get; set; }

        public string FavoriteFilipinoHero { get; set; }
         

    }
}

