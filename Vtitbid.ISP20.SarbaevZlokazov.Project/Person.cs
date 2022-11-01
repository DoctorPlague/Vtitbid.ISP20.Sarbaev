namespace Vtitbid.ISP20.Sarbaev.Note
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DayOfBirth { get; set;}
        public Person (string firstname, string lastname, string phoneNumber, DateTime dateTime)
        {
            Firstname = firstname;
            Lastname = lastname;
            PhoneNumber = phoneNumber;
            DayOfBirth = dateTime;
        }
        public override string ToString()
        {
            return $"Имя: {Firstname}\nФамилия: {Lastname}\nНомер телефона: {PhoneNumber}\nДата рождения: {DayOfBirth.ToShortDateString()}";
        }
    }
}
