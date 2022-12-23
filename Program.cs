using System;
using oop2_3.Pupils;

namespace oop2_3
{
    class Program
    {
        static void Main()
        {
            ExcelentPupil exPupil_1 =   new ExcelentPupil("Dmitry", "Sokolov");
            GoodPupil gPupil_1      =   new GoodPupil("Sergey", "Rykhtorov");
            BadPupil bPupil_1       =   new BadPupil("Nikola", "Kovac");
            GoodPupil gPupil_2      =   new GoodPupil("Robin", "Kool");

            ClassRoom cRoom = new ClassRoom(exPupil_1 , gPupil_1, bPupil_1, gPupil_2);

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();

            Console.WriteLine("Grades");
            foreach (Pupil p in cRoom.arrPupil)
            {
                Console.WriteLine(p.GetCurrentGrade);
            }

            Console.WriteLine("Round Grade");
            Console.WriteLine(cRoom.GetRoundGrade);
        }
    }
}