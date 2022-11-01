using Vtitbid.ISP20.Sarbaev.Note;
//Вариант 13
List<Person> note = new List<Person>();
int counter = 4;

PersonAction.InicialisePerson(ref note, counter);

PersonAction.AlphabetSort(ref note);

Console.WriteLine("Введите месяц для поиска");

PersonAction.FindDayOfBirth(note, Int32.Parse(Console.ReadLine()));

PersonAction.GetPersonsInfo(note);
