using System;

namespace oop2_3.Pupils
{
    public sealed class BadPupil : Pupil
    {
        public override int GetCurrentGrade { get; }
        public new string FirstName { get; }
        public new string SecondName { get; }

        public BadPupil(string firstName, string secondName) : base(firstName, secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            Random GetCurrentGrade = new Random();
            this.GetCurrentGrade = GetCurrentGrade.Next(2, 6);                  // Случайная оценка от 2 до 5
        }
        public override string Study()
        {
            return $"{FirstName} {SecondName}: Study-bad";
        }
        public override string Read()
        {
            return $"{FirstName} {SecondName}: Read-bad";
        }
        public override string Write()
        {
            return $"{FirstName} {SecondName}: Write-bad";
        }
        public override string Relax()
        {
            return $"{FirstName} {SecondName}: Relax-bad";
        }
    }
}