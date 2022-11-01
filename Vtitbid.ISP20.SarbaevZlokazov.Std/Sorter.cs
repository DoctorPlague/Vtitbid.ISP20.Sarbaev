using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Sarbaev.Student
{
    public static class Sorter
    {
        public static void Sort(List<Student> students)
        {
            Console.WriteLine("Выберите способ сортировки:\n1. Сортировка по алфавиту\n2. Сортировка по среднему баллу");

            byte.TryParse(Console.ReadLine(), out byte temp);

            switch (temp)
            {
                case 1:
                    Sorter.AlphabetSortWay(ref students);
                    break;
                case 2:
                    Sorter.MarkSortWay(ref students);
                    break;
                default:
                    Console.WriteLine("Метод сортировки не распознан");
                    return;
            }
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
        private static void AlphabetSortWay(ref List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count - 1; j++)
                {
                    if (Alphabet(students[i].Lastname, students[j].Lastname))
                    {
                        Student empty = students[i];
                        students[i] = students[j];
                        students[j] = empty;
                    }
                }
            }
        }
        private static bool Alphabet(string a, string b)
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
        private static void MarkSortWay(ref List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count - 1; j++)
                {
                    double MiddleValueI = (students[i].FirstMark + students[i].SecondMark + students[i].ThirdMark) / 3;
                    double MiddleValueJ = (students[j].FirstMark + students[j].SecondMark + students[j].ThirdMark) / 3;
                    if (MiddleValueI > MiddleValueJ)
                    {
                        Student empty = students[i];
                        students[i] = students[j];
                        students[j] = empty;
                    }
                }
            }
        }
    }
}
