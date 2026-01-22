namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{
    internal class Program
    {
        /*
        INSTRUCTION

        OPEN FirstPart.cs and SecondPart.cs. 
        Read the instruction in each file and provide the necessary code to complete the task.
        */

        static void Main(string[] args)
        {
            new FirstPart();

            Console.WriteLine("--------------------------------------------------");

            new SecondPart().Build();

            Console.WriteLine("--------------------------------------------------");

            new ThirdPart().Build();

            Console.ReadKey();
        }
    }
}
