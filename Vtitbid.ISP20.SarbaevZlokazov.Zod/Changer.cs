namespace Vtitbid.ISP20.Sarbaev.Zodiac
{
    public class Changer
    {
        public static event Action<string, string, string> ChangeEvent = WriteToTextEvent;

        static readonly Action<string> writer = Console.WriteLine;
        static readonly Func<string> reader = Console.ReadLine;
        public static void Change(ref List<Person> persons, int place)
        {
            Person temp = persons[place];
            writer(persons[place].ToString());
            writer("Что вы хотите изменить?:\n1)Имя\n2)Фамилия\n3)Дата рождения\n4)Всю запись\n5)Удалить");
            int choice = Int32.Parse(reader());
            string initialValue;
            string finalValue;
            switch (choice)
            {
                case 1:
                    initialValue = persons[place].FirstName;
                    ChangeName(ref persons, place);
                    finalValue = persons[place].FirstName;
                    ChangeEvent(initialValue, finalValue, "Имя");
                    break;
                case 2:
                    initialValue = persons[place].LastName;
                    ChangeSurname(ref persons, place);
                    finalValue = persons[place].LastName;
                    ChangeEvent(initialValue, finalValue, "Фамилия");
                    break;
                case 3:
                    initialValue = persons[place].DayOfBirth.ToShortDateString();
                    ChangeDate(ref persons, place);
                    finalValue = persons[place].DayOfBirth.ToShortDateString();
                    ChangeEvent(initialValue, finalValue, "Дата рождения");
                    break;
                case 4:
                    initialValue = persons[place].ToString();
                    ChangeAll(ref persons, place);
                    finalValue = persons[place].ToString();
                    ChangeEvent(initialValue, finalValue, "ReWrite");
                    break;
                case 5:
                    initialValue = persons[place].ToString();
                    persons.Remove(persons[place]);
                    finalValue = " ";
                    ChangeEvent(initialValue, finalValue, "Remove");
                    break;
                default:
                    Console.WriteLine("BRuh");
                    break;
            }
        }
        static void ChangeDate(ref List<Person> persons, int place)
        {
            bool checker = true;
            while (checker)
            {
                writer("Введите новое значение");
                if (!DateTime.TryParse(reader(), out DateTime date))
                    continue;
                string name = persons[place].FirstName;
                string lastname = persons[place].LastName;
                persons.Remove(persons[place]);
                persons.Insert(place, new Person(name, lastname, date));
                PersonAction.SortDate(ref persons);
                checker = false;
            }
        }
        static void ChangeName(ref List<Person> persons, int place)
        {
            writer("Введите новое значение");
            string name = reader();
            persons[place].FirstName = name;
        }
        static void ChangeSurname(ref List<Person> persons, int place)
        {
            writer("Введите новое значение");
            string lastname = reader();
            persons[place].LastName = lastname;
        }
        static void ChangeAll(ref List<Person> persons, int place)
        {
            bool checker = false;
            while (!checker)
            {
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
                persons.Remove(persons[place]);
                persons.Insert(place, new Person(firstname, lastname, dayofbirth));
                checker = true;
            }
        }
        static void WriteToTextEvent(string initial, string final, string prop)
        {
            if (prop == "Remove")
            {
                File.AppendAllText("Changes.Txt", $"Запись о человеке:\n{initial}->была удалена. {DateTime.Now};\n\n");
            }
            else if (prop == "ReWrite")
            {
                File.AppendAllText("Changes.Txt", $"Запись о человекe:\n{initial}была перезаписана ->\n{final}{DateTime.Now};\n\n");
            }
            else
            {
                File.AppendAllText("Changes.Txt", $"Свойство \"{prop}\" было изменено: {initial} -> {final}. {DateTime.Now};\n\n");
            }
        }
    }
}
