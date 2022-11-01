namespace Vtitbid.ISP20.Sarbaev.Zodiac
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Zodiaс { get;}
        public Person(string firstname, string lastname, DateTime dayofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            DayOfBirth = dayofbirth;
            Zodiaс = ZodiacSignToString();
        }
        public override string ToString()
        {
            return $"Фамилия: {LastName}\nИмя: {FirstName}\nДата рождения: {DayOfBirth.ToShortDateString()}\nЗнак зодиака: {Zodiaс}\n"; 
        }
        private ZodiacSign ZodiaсSelector()
        {
            if ((DayOfBirth.Month == 1 && DayOfBirth.Day >= 21) || (DayOfBirth.Month == 2 && DayOfBirth.Day <= 18))
                return ZodiacSign.Aquarius;
            else if ((DayOfBirth.Month == 2 && DayOfBirth.Day >= 19) || (DayOfBirth.Month == 3 && DayOfBirth.Day <= 20))
                return ZodiacSign.Pisces;
            else if ((DayOfBirth.Month == 3 && DayOfBirth.Day >= 21) || (DayOfBirth.Month == 4 && DayOfBirth.Day <= 20))
                return ZodiacSign.Aries;
            else if ((DayOfBirth.Month == 4 && DayOfBirth.Day >= 21) || (DayOfBirth.Month == 5 && DayOfBirth.Day <= 21))
                return ZodiacSign.Taurus;
            else if ((DayOfBirth.Month == 5 && DayOfBirth.Day >= 22) || (DayOfBirth.Month == 6 && DayOfBirth.Day <= 21))
                return ZodiacSign.Gemini;
            else if ((DayOfBirth.Month == 6 && DayOfBirth.Day >= 22) || (DayOfBirth.Month == 7 && DayOfBirth.Day <= 22))
                return ZodiacSign.Cancer;
            else if ((DayOfBirth.Month == 7 && DayOfBirth.Day >= 23) || (DayOfBirth.Month == 8 && DayOfBirth.Day <= 21))
                return ZodiacSign.Leo;
            else if ((DayOfBirth.Month == 8 && DayOfBirth.Day >= 24) || (DayOfBirth.Month == 9 && DayOfBirth.Day <= 22))
                return ZodiacSign.Virgo;
            else if ((DayOfBirth.Month == 9 && DayOfBirth.Day >= 23) || (DayOfBirth.Month == 10 && DayOfBirth.Day <= 23))
                return ZodiacSign.Libra;
            else if ((DayOfBirth.Month == 10 && DayOfBirth.Day >= 24) || (DayOfBirth.Month == 11 && DayOfBirth.Day <= 22))
                return ZodiacSign.Scorpio;
            else if ((DayOfBirth.Month == 11 && DayOfBirth.Day >= 23) || (DayOfBirth.Month == 12 && DayOfBirth.Day <= 21))
                return ZodiacSign.Sagittarius;
            else if ((DayOfBirth.Month == 12 && DayOfBirth.Day >= 22) || (DayOfBirth.Month == 1 && DayOfBirth.Day <= 20))
                return ZodiacSign.Capricorn;

            return ZodiacSign.Empty;
        }
        private string ZodiacSignToString()
        {
            ZodiacSign zodiac = ZodiaсSelector();
            switch (zodiac)
            {
                case ZodiacSign.Libra: return "Весы";
                case ZodiacSign.Aries: return "Овен";
                case ZodiacSign.Taurus: return "Телец";
                case ZodiacSign.Gemini: return "Близнецы";
                case ZodiacSign.Cancer: return "Рак";
                case ZodiacSign.Leo: return "Лев";
                case ZodiacSign.Virgo: return "Дева";
                case ZodiacSign.Scorpio: return "Скорпион";
                case ZodiacSign.Sagittarius: return "Стрелец";
                case ZodiacSign.Capricorn: return "Козерог";
                case ZodiacSign.Aquarius: return "Водолей";
                case ZodiacSign.Pisces: return "Рыбы";
            }
            return "Не определено";
        }

    }
}
