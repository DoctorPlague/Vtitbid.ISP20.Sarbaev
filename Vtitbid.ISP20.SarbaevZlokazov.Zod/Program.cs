using Vtitbid.ISP20.Sarbaev.Zodiac;

List<Person> persons = PersonAction.CreatePersonArray(0);
bool checker = true;
while (checker)
{
    Console.WriteLine("1)Вывести информацию\n2)Редактировать информацию");
    int empty = Int32.Parse(Console.ReadLine());
    switch (empty)
    {
        case 1:
            PersonAction.GetInfo(persons);
            break;
        case 2:
            PersonAction.GetInfo(persons);
            Console.WriteLine("Введите порядковый номер");
            int pointer = Int32.Parse(Console.ReadLine());
            if (pointer <= persons.Count)
                Changer.Change(ref persons, pointer-1);
            break;
        default:
            checker = false;
            break;
    }
}
