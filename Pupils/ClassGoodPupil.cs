using System;

namespace oop2_3.Pupils
{
    public sealed class GoodPupil : Pupil
    {
        public override int GetCurrentGrade { get; }
        public new string FirstName { get; }
        public new string SecondName { get; }

        public GoodPupil(string firstName, string secondName) : base(firstName, secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            Random GetCurrentGrade = new Random();
            this.GetCurrentGrade = GetCurrentGrade.Next(3, 6);                  // Случайная оценка от 3 до 5
        }
        public override string Study()
        {
            return $"{FirstName} {SecondName}: Study-good";
        }
        public override string Read()
        {
            return $"{FirstName} {SecondName}: Read-good";
        }
        public override string Write()
        {
            return $"{FirstName} {SecondName}: Write-good";
        }
        public override string Relax()
        {
            return $"{FirstName} {SecondName}: Relax-good";
        }
    }
}