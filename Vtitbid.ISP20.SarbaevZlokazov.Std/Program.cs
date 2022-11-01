using Vtitbid.ISP20.Sarbaev.Student;

string[] students =  File.ReadAllLines("Students.txt");

List<Student> pupil = Student.SplitData(students);

Sorter.Sort(pupil);


