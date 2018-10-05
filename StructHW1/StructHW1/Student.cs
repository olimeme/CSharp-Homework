using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructHW1
{
    public class Student
    {
        private string FullName { get; set; }
        private string Group { get; set; }
        private int AvgMark { get; set; }
        private int SalaryOfFamilyMemeber { get; set; }
        private Genders Gender { get; set; }
        private StudyTypes StudyType { get; set; }

        public Student(string fullName, string group,int avgMark,int salary, Genders gender,StudyTypes study)
        {
            FullName = fullName;
            Group = group;
            AvgMark = avgMark;
            SalaryOfFamilyMemeber = salary;
            Gender = gender;
            StudyType = study;
        }

        public string GetName()
        {
            return FullName;
        }

        public void SetName(string name)
        {
            FullName = name;
        }

        public string GetGroup()
        {
            return Group;
        }

        public void SetGroup(string group)
        {
            Group = group;
        }

        public int GetAvgMark()
        {
            return AvgMark;
        }

        public void SetAvgMark(int mark)
        {
            AvgMark = mark;
        }

        public int GetSalary()
        {
            return SalaryOfFamilyMemeber;
        }

        public void SetSalary(int salary)
        {
            SalaryOfFamilyMemeber = salary;
        }

        public Genders GetGender()
        {
            return Gender;
        }

        public void SetGender(Genders gender)
        {
            Gender = gender;
        }

        public StudyTypes GetStudyType()
        {
            return StudyType;
        }

        public void SetStudyType(StudyTypes studyTypes)
        {
            StudyType = studyTypes;
        }

        public void PrintInfo()
        {
            WriteLine("Полное имя: " + FullName);
            WriteLine("Группа: " + Group);
            WriteLine("Зарплата: " + SalaryOfFamilyMemeber);
            WriteLine("Средняя оценка: " + AvgMark);
            WriteLine("-----------------------------------");
        }
    }
}
