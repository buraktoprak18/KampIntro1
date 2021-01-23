using System;

namespace OdevleAlakalıArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Burak";
            students[1] = "Eren";
            students[2] = "Ahmet";

            string[] students2 = new[] {"Burak", "Eren",};
               

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
