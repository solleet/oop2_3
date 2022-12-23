namespace oop2_3
{
    public class Pupil
    {
        public string FirstName { get; }                            // Имя ученика
        public string SecondName { get; }                           // Фамилия ученика
        
        public virtual int GetCurrentGrade { get; }                 // Св-во Оценки ученика

        public Pupil(string firstName, string secondName)           // Кон-р класса ученика
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.GetCurrentGrade = 0;
        }

        public virtual string Study()
        { return $"{FirstName} {SecondName}: study"; }
        public virtual string Read()
        { return $"{FirstName} {SecondName}: read"; }
        public virtual string Write()
        { return $"{FirstName} {SecondName}: write"; }
        public virtual string Relax()
        { return $"{FirstName} {SecondName}: relax"; }
    }
}