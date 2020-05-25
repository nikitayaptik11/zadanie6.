using System;
using System.Collections.Generic;

namespace Zadanie_6
{
    class Program
    {
        public class Student
        {
            public string id;
            public string fio;
            public string group;
            public string birthDate;
        }

        static List<Student> studentList = new List<Student>();

        static void AddStudent(string id, string fio, string birthDate, string group)
        {
            studentList.Add(new Student() { id = id, fio = fio, birthDate = birthDate, group = group });
        }


        static void DelStudent(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id) studentList.RemoveAt(i);
            }
        }

        static void ChangeStudent(string id, string fio, string birthDate, string group)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    studentList[i].fio = fio;
                    studentList[i].birthDate = birthDate;
                    studentList[i].group = group;
                }
            }

        }

        static void ShowStudentFio()
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + studentList[i].fio);
            }
            Console.WriteLine();
        }

        static void ShowStudentById(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                    Console.WriteLine(
                        studentList[i].id + " - "
                        + studentList[i].fio + " - "
                        + studentList[i].birthDate + " - "
                        + studentList[i].group
                    );
            }
            Console.WriteLine();
        }

        static void ShowStudentAge(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    string[] studentListSplit = studentList[i].birthDate.Split(".");
                    int ourYear = 2020;

                    if (int.TryParse(studentListSplit[2], out int res)) Console.Write("Возраст студента с id " + id + ": " + (ourYear - res) + " лет");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student first = new Student();

            AddStudent("1567", "Лорд Геннадий Байрон", "11.08.2000", "ISIP");
            AddStudent("1668", "Салтыков Дмитрий Гюгов", "23.11.1999", "ASAP");
            AddStudent("2208", "Лермонтов Степан Халтурин", "07.02.1999", "ACAB");
            ShowStudentFio();
            ShowStudentById("2208");
            ShowStudentAge("1567");
        }
    }
}