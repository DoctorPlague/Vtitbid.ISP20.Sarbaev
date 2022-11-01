using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Sarbaev.Note
{
    static class PersonAction
    {
        public static void AlphabetSort(ref List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - 1; j++)
                {
                    if (AlphabetSortWay(persons[i].Lastname, persons[j].Lastname))
                    {
                        Person empty = persons[i];
                        persons[i] = persons[j];
                        persons[j] = empty;
                    }
                }
            }
        }
        private static bool AlphabetSortWay(string a, string b)
        {
            string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string aUp = a.ToUpper();
            string bUp = b.ToUpper();

            int counter = (a.Length < b.Length) ? a.Length : b.Length;

            for (int i = 0; i < counter; i++)
            {
                if (Alphabet.IndexOf(aUp[i]) < Alphabet.IndexOf(bUp[i]))
                {
                    return true;
                }
                else if (Alphabet.IndexOf(aUp[i]) == Alphabet.IndexOf(bUp[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static void FindDayOfBirth(List<Person> person, int month)
        {
            Console.WriteLine("Совпадения:\n");
            bool check = false;
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].DayOfBirth.Month == month)
                {
                    Console.WriteLine(person[i].ToString() + "\n");
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Человека с такой датой рождения нет в списке");
            }
        }
        static public void GetPersonsInfo(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(people[i]); 
            }
        }
        static public void PaintAsError(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static public void InicialisePerson(ref List<Person> persons, int counter)
        {
            int i = 0;
            while (i < counter)
            {
                Console.WriteLine("№" + (i + 1));
                Console.WriteLine("Имя: ");
                string? firstname = Console.ReadLine();
                Console.WriteLine("Фамилия: ");
                string? lastname = Console.ReadLine();
                Console.WriteLine("Номер телефона: ");
                string? number = Console.ReadLine();
                Console.WriteLine("Дата рождения: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime temp) && !String.IsNullOrEmpty(lastname) && !String.IsNullOrEmpty(firstname))
                {
                    persons.Add(new Person(firstname, lastname, number, temp));
                    i++;
                }
                else
                {
                    PersonAction.PaintAsError("Ошибка в вводе данных");
                }

            }
        }
    }

}
