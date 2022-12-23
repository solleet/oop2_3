using oop2_3.Pupils;

namespace oop2_3
{
    [TestFixture]
    class ClassRoomTest
    {
        // Тест 1 Проверка Кол-ва учеников 1
        [Test]
        public void QuantityOfPupilsIsTrueFirst()
        {
            ExcelentPupil exPupil_1 = new ExcelentPupil("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new GoodPupil("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new BadPupil("Nikola", "Kovac");
            GoodPupil gPupil_2 = new GoodPupil("Robin", "Kool");

            ClassRoom cRoom = new ClassRoom(exPupil_1, gPupil_1, bPupil_1, gPupil_2);

            int Count = 0;

            foreach (Pupil p in cRoom.arrPupil)
                Count++;
            Assert.AreEqual(Count, ClassRoom.QuantityOfPupils);
        }

        // Тест 2 Проверка Кол-ва учеников 2
        [Test]
        public void QuantityOfPupilsIsTrueSecond()
        {
            ExcelentPupil exPupil_1 = new ExcelentPupil("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new GoodPupil("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new BadPupil("Nikola", "Kovac");

            ClassRoom cRoom = new ClassRoom(exPupil_1, gPupil_1, bPupil_1);

            int Count = 0;
            
            foreach (Pupil p in cRoom.arrPupil)
                Count++;
            Assert.AreEqual(Count, ClassRoom.QuantityOfPupils);
        }

        // Тест 3 Проверка Оценок учеников
        [Test]
        public void GadesIsTrue()
        {
            ExcelentPupil exPupil_1 = new ExcelentPupil("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new GoodPupil("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new BadPupil("Nikola", "Kovac");
            GoodPupil gPupil_2 = new GoodPupil("Robin", "Kool");

            Assert.IsTrue(exPupil_1.GetCurrentGrade >= 4 && exPupil_1.GetCurrentGrade <= 5);
            Assert.IsTrue(gPupil_1.GetCurrentGrade >= 3 && gPupil_1.GetCurrentGrade <= 5);
            Assert.IsTrue(bPupil_1.GetCurrentGrade >= 2 && bPupil_1.GetCurrentGrade <= 5);
        }

        // Тест 4 Проверка Средней оценки в классе
        [Test]
        public void RoundGadesIsTrue()
        {
            ExcelentPupil exPupil_1 = new ExcelentPupil("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new GoodPupil("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new BadPupil("Nikola", "Kovac");

            ClassRoom cRoom = new ClassRoom(exPupil_1, gPupil_1, bPupil_1);

            double round = (exPupil_1.GetCurrentGrade + gPupil_1.GetCurrentGrade + bPupil_1.GetCurrentGrade) / (double)3;
            Assert.That(cRoom.GetRoundGrade, Is.EqualTo(round));
        }
        // Тест 5 Проверка "Обучения" учеников
        [Test]
        public void StudyIsTrue()
        {
            ExcelentPupil exPupil_1 = new ("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new ("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new ("Nikola", "Kovac");

            Assert.AreEqual(exPupil_1.Study(), "Dmitry Sokolov: Study-excelent");
            Assert.AreEqual(gPupil_1.Study(), "Sergey Rykhtorov: Study-good");
            Assert.AreEqual(bPupil_1.Study(), "Nikola Kovac: Study-bad");
        }

        // Тест 6 Проверка "Чтения" учеников
        [Test]
        public void ReadIsTrue()
        {
            ExcelentPupil exPupil_1 = new("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new("Nikola", "Kovac");

            Assert.AreEqual(exPupil_1.Read(), "Dmitry Sokolov: Read-excelent");
            Assert.AreEqual(gPupil_1.Read(), "Sergey Rykhtorov: Read-good");
            Assert.AreEqual(bPupil_1.Read(), "Nikola Kovac: Read-bad");
        }

        // Тест 7 Проверка "Письма" учеников
        [Test]
        public void WriteIsTrue()
        {
            ExcelentPupil exPupil_1 = new("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new("Nikola", "Kovac");

            Assert.AreEqual(exPupil_1.Write(), "Dmitry Sokolov: Write-excelent");
            Assert.AreEqual(gPupil_1.Write(), "Sergey Rykhtorov: Write-good");
            Assert.AreEqual(bPupil_1.Write(), "Nikola Kovac: Write-bad");
        }

        // Тест 8 Проверка "Отдыха" учеников 1
        [Test]
        public void RelaxIsTrueFirst()
        {
            ExcelentPupil exPupil_1 = new("Dmitry", "Sokolov");
            GoodPupil gPupil_1 = new("Sergey", "Rykhtorov");
            BadPupil bPupil_1 = new("Nikola", "Kovac");

            Assert.AreEqual(exPupil_1.Relax(), "Dmitry Sokolov: Relax-excelent");
            Assert.AreEqual(gPupil_1.Relax(), "Sergey Rykhtorov: Relax-good");
            Assert.AreEqual(bPupil_1.Relax(), "Nikola Kovac: Relax-bad");
        }

        // Тест 9 Проверка "Отдыха" учеников 2
        [Test]
        public void RelaxIsTrueSecond()
        {
            Pupil exPupil_1 = new ExcelentPupil("Dmitry", "Sokolov");
            Pupil gPupil_1 = new GoodPupil("Sergey", "Rykhtorov");
            Pupil bPupil_1 = new BadPupil("Nikola", "Kovac");

            Assert.AreEqual(exPupil_1.Relax(), "Dmitry Sokolov: Relax-excelent");
            Assert.AreEqual(gPupil_1.Relax(), "Sergey Rykhtorov: Relax-good");
            Assert.AreEqual(bPupil_1.Relax(), "Nikola Kovac: Relax-bad");
        }
        // Тест 10 Проверка Класса ученика-родителя
        [Test]
        public void PupilTest()
        {
            Pupil pupil = new ("Ivan", "Ivanov");

            Assert.AreEqual(pupil.Study(), "Ivan Ivanov: study");
            Assert.AreEqual(pupil.Read(), "Ivan Ivanov: read");
            Assert.AreEqual(pupil.Write(), "Ivan Ivanov: write");
            Assert.AreEqual(pupil.Relax(), "Ivan Ivanov: relax");
        }
    }
}
