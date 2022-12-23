using oop2_3.Pupils;

namespace oop2_3
{
    [TestFixture]
    class ClassRoomTest
    {
        // ���� 1 �������� ���-�� �������� 1
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

        // ���� 2 �������� ���-�� �������� 2
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

        // ���� 3 �������� ������ ��������
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

        // ���� 4 �������� ������� ������ � ������
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
        // ���� 5 �������� "��������" ��������
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

        // ���� 6 �������� "������" ��������
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

        // ���� 7 �������� "������" ��������
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

        // ���� 8 �������� "������" �������� 1
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

        // ���� 9 �������� "������" �������� 2
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
        // ���� 10 �������� ������ �������-��������
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
