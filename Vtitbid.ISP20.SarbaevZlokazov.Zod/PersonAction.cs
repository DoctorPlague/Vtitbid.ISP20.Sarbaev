namespace Vtitbid.ISP20.Sarbaev.Zodiac
{
    public static class PersonAction
    {
        static readonly Action<string> writer = Console.WriteLine;
        static readonly Func<string> reader = Console.ReadLine;
        public static List<Person> CreatePersonArray(int count)
        {
            var person = new List<Person>()
            {
                new Person("Константин","Савин", new DateTime(2004,05,07)),
                new Person("Диана", "Беликова", new DateTime(1995,02,01)),
                new Person("Михаил","Беликов", new DateTime(2000,09,27)),
                new Person("Надежда","Любимова", new DateTime(2002,03,23)),
                new Person("Родион","Филатов", new DateTime(1999,01,01))
            };
            Inicialize(ref person, count);
            SortDate(ref person);
            return person;
        }
        public static void Inicialize(ref List<Person> people, int count)
        {
            int i = 0;
            while (i < count)
            {
                writer("№" + (i+1));
                writer("Введите Имя:");
                string firstname = reader();
                writer("Введите Фамилию:");
                string? lastname = reader();
                writer("Введите Дату рождения:");
                bool check = DateTime.TryParse(reader(), out DateTime dayofbirth);
                if (!check || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
                {
                    writer("Некорректные данные");
                    continue;
                }
                people.Add(new Person(firstname, lastname, dayofbirth));
                writer($"Знак зодиака: {people[i].Zodiaс}");
                i++;
            }
        }
        public static void SortDate(ref List<Person> person)
        {
            for (int i = 0; i < person.Count; i++)
            {
                for (int j = 0; j < person.Count - 1; j++)
                {
                    if (person[i].DayOfBirth.Date < person[j].DayOfBirth.Date)
                    {
                        (person[j], person[i]) = (person[i], person[j]);
                    }
                }
            }
        }
        public static void FindZodiaс(List<Person> person)
        {
            writer("Введите знак зодиака для поиска");
            string zodiaс = reader();
            bool check = false;
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].Zodiaс == zodiaс)
                {
                    writer("-----------------------------\n" + person[i]);
                    check = true;
                }
            }
            if (!check)
            {
                writer("Не найдено");
            }
        }
        public static void GetInfo(List<Person> person)
        {
            for (int i = 0; i < person.Count; i++)
            {
                writer(person[i].ToString());
                writer("----------------------------");
            }
        }
    }
}