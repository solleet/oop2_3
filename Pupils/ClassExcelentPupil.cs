using System;

namespace oop2_3.Pupils
{
    public sealed class ExcelentPupil : Pupil
    {
        public override int GetCurrentGrade { get; }
        public new string FirstName { get; }
        public new string SecondName { get; }

        public ExcelentPupil(string firstName, string secondName) : base(firstName, secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            Random GetCurrentGrade = new Random();
            this.GetCurrentGrade = GetCurrentGrade.Next(4, 6);              // Случайная оценка от 4 до 5
        }

        public override string Study()
        {
            return $"{FirstName} {SecondName}: Study-excelent";
        }
        public override string Read()
        {
            return $"{FirstName} {SecondName}: Read-excelent";
        }
        public override string Write()
        {
            return $"{FirstName} {SecondName}: Write-excelent";
        }
        public override string Relax()
        {
            return $"{FirstName} {SecondName}: Relax-excelent";
        }
    }
}