using System;

namespace oop2_3
{
    public class ClassRoom
    {
        public Pupil[] arrPupil;                                                            // Массив учеников

        public static int QuantityOfPupils = 0;                                                    // Кол-во учеников в классе
        static int GradeSum = 0;                                                            // Сумма оценок учеников
        public double GetRoundGrade                                                         // Свойство, определяющее среднюю оценку в классе
        {
            get                                                                             // Доступно только для чтения
            {
                foreach (Pupil p in arrPupil)                                               // Проходимся по ученикам из массива
                    GradeSum += p.GetCurrentGrade;                                          // Считаем сумму
                return QuantityOfPupils != 0 ? (double)GradeSum / QuantityOfPupils : 0;     // если кол-во учеников 0 - возвращает 0
            }                                                                               // если нет, то сумма делится на кол-во учеников
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)                            // Конструктор для 4х
        {
            arrPupil = new Pupil[] { p1, p2, p3, p4 };
            QuantityOfPupils = 4;
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)                                      // Конструктор для 3х
        {
            arrPupil = new Pupil[] { p1, p2, p3 };
            QuantityOfPupils = 3;
        }
        public ClassRoom(Pupil p1, Pupil p2)                                                // Конструктор для 2х
        {
            arrPupil = new Pupil[] { p1, p2 };
            QuantityOfPupils = 2;
        }

        public void PrintInfoStudy()                                                        // Вывод информации об обучении учеников
        {
            Console.WriteLine("Study: ");
            foreach (Pupil p in arrPupil)
                Console.WriteLine(p.Study());
        }
        public void PrintInfoRead()                                                         // Вывод информации о чтении учеников
        {
            Console.WriteLine("Read: ");
            foreach (Pupil p in arrPupil)
                Console.WriteLine(p.Read());
        }
        public void PrintInfoWrite()                                                        // Вывод информации о письме учеников
        {
            Console.WriteLine("Write: ");
            foreach (Pupil p in arrPupil)
                Console.WriteLine(p.Write());
        }
        public void PrintInfoRelax()                                                        // Вывод информации об отдыхе учеников
        {
            Console.WriteLine("Relax: ");
            foreach (Pupil p in arrPupil)
                Console.WriteLine(p.Relax());
        }
    }
}