using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructHW1
{
    class Program
    {
        const int MinimalSalary = 80000;

        static List<Student> SortBySalary(List<Student> list)
        {
            var externalList = new List<Student>();

            for (int i = 0; i < list.Count; i++)
                if (list[i].GetSalary() < (2 * MinimalSalary))
                    externalList.Add(list[i]);

            var sortedList = list;

            for (int i = 0; i < list.Count; i++)
                for (int j = list.Count - 1; j > i; j--)
                    if (list[j - 1].GetAvgMark() > list[j].GetAvgMark())
                    {
                        sortedList[i] = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = sortedList[i]; 
                    }

            for(int i=0;i<list.Count;i++)
                if (list[i].GetSalary() < (2 * MinimalSalary))
                    list.Remove(list[i]);

            for (int i = 0; i < list.Count; i++)
                externalList.Add(list[i]);

            return externalList;
        }

        static void Main(string[] args)
        {
            var students = new List<Student>();

            Student student1 = new Student("Adolf Mah Dude", "SDP-172", 10, 170000, Genders.Male, StudyTypes.FullTime);
            Student student2 = new Student("Big Boi Bob", "SDP-181", 11, 170000, Genders.Male, StudyTypes.FullTime);
            Student student3 = new Student("9/11 was an inside job", "SDB-192", 12, 170000, Genders.Male, StudyTypes.FullTime);
            Student student4 = new Student("ok", "SDP-172", 9, 40000, Genders.Male, StudyTypes.FullTime);
            Student student5 = new Student("Im running out of ideas", "SDP-172", 8, 40000, Genders.Male, StudyTypes.FullTime);
            Student student6 = new Student("Yamete", "SDP-172", 12, 40000, Genders.Male, StudyTypes.FullTime);

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);

            WriteLine("------------------BEFORE------------------");
            for (int i = 0; i < students.Count; i++)
                students[i].PrintInfo();

            WriteLine("------------------AFTER------------------");
            students = SortBySalary(students);

            for(int i=0;i<students.Count;i++)
                students[i].PrintInfo();
            ReadLine();
        }
    }
}
