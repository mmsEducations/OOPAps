using System;
using System.Collections.Generic;

namespace Apps3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School schoolIsmetPasa = new School() { Name = "İsmet Paşa İlkOretim Okulu", Code = 1001 };
            School schoolMustafaKemal = new School() { Name = "Mustafa Kemal İlkOretim Okulu", Code = 1002 };

            Teacher tBurak = new Teacher() { Name = "Burak Asaf", LastName = "Sincar", BirthDate = new DateTime(2020, 4, 29) };
            Teacher tYigit = new Teacher() { Name = "Yiğit Ali", LastName = "Sincar", BirthDate = new DateTime(2021, 8, 1) };
            Teacher tMuhammed = new Teacher() { Name = "Muhamed", LastName = "Abdullah", BirthDate = new DateTime(571, 2, 1) };
            Teacher tAdriana = new Teacher() { Name = "Adriana", LastName = "Lima", BirthDate = new DateTime(1990, 12, 1), Gender = Gender.Female };

            var lessonAli1 = new Lesson() { Code = 2000, Name = "Matematik", Vize = 10, Final = 100 };
            var lessonAli2 = new Lesson() { Code = 2001, Name = "Fizik", Vize = 100, Final = 40 };
            List<Lesson> lessonsAli = new List<Lesson>();
            lessonsAli.Add(lessonAli1);
            lessonsAli.Add(lessonAli2);

            Student sAli = new Student()
            {
                Name = "Muhammed Ali",
                LastName = "Çetin",
                BirthDate = new DateTime(2000, 2, 1),
                Number = "1",
                Teacher = tBurak,
                School = schoolIsmetPasa,
                //Lessons = new List<Lesson>() { new Lesson() { Code = 2000, Name = "Matematik" }, new Lesson() { Code = 2001, Name = "Fizik" } }
                Lessons = lessonsAli
            };


            Lesson lessonAleyna = new Lesson() { Code = 2000, Name = "Matematik", Vize = 100, Final = 100 };

            Lesson lessonAleyna2 = new Lesson() { Code = 2001, Name = "Fizik", Vize = 100, Final = 100 };

            Student sAlleyna = new Student()
            {
                Name = "Aleyna",
                LastName = "Uzan",
                BirthDate = new DateTime(1998, 12, 7),
                Number = "2",
                Teacher = tYigit,
                School = schoolMustafaKemal,
                //Lessons = new List<Lesson>() { new Lesson() { Code = 2000, Name = "Matematik" }, new Lesson() { Code = 2001, Name = "Fizik" } }
                Lessons = new List<Lesson> { lessonAleyna, lessonAleyna2 },
                Gender = Gender.Female
            };

            Student sSerdar = new Student()
            {
                Name = "Serdar",
                LastName = "Deniz",
                BirthDate = new DateTime(1997, 3, 2),
                Number = "3",
                Teacher = tMuhammed,
                School = schoolMustafaKemal,
                Lessons = new List<Lesson> {
                      new Lesson() { Code = 2000, Name = "Matematik", Vize = 100, Final = 100 },
                      new Lesson() { Code = 2001, Name = "Fizik", Vize = 50, Final = 100 },
                       new Lesson() { Code = 2002, Name = "Bilgisayar", Vize = 100, Final = 100 }
                }
            };

            Student sNursena = new Student()
            {
                Name = "Nursena",
                LastName = "Namlı",
                BirthDate = new DateTime(2003, 4, 3),
                Number = "4",
                Teacher = tMuhammed,
                School = schoolIsmetPasa,
                Lessons = new List<Lesson> {
                       new Lesson() { Code = 2000, Name = "Matematik", Vize = 0, Final = 0 },
                       new Lesson() { Code = 2001, Name = "Fizik", Vize = 50, Final = 10 },
                       new Lesson() { Code = 2002, Name = "Bilgisayar", Vize = 50, Final = 50 },
                       new Lesson() { Code = 2002, Name = "Kimya", Vize = 100, Final = 100 },
                },
                Gender = Gender.Female
            };

            Student sMehmet = new Student()
            {
                Name = "Mehmet",
                LastName = "Çiftçi",
                BirthDate = new DateTime(199, 7, 25),
                Number = "5",
                Teacher = tMuhammed,
                School = new School() { Code = 1003, Name = "Mehmet KüçükParmak" },
                Lessons = new List<Lesson> {
                       new Lesson() { Code = 2000, Name = "Matematik", Vize = 0, Final = 0 },
                       new Lesson() { Code = 2001, Name = "Fizik", Vize = 50, Final = 10 },
                       new Lesson() { Code = 2002, Name = "Bilgisayar", Vize = 50, Final = 50 },
                       new Lesson() { Code = 2002, Name = "Kimya", Vize = 100, Final = 100 },
                },
                Gender = Gender.Male
            };

            List<Student> studentList = new List<Student>()
            {
                sAli,
                sAlleyna,
                sSerdar,
                sNursena,
                sMehmet,
                 new Student()
                {
                    Name = "Engin",
                    LastName = "Küçük",
                    BirthDate = new DateTime(1980, 1, 1),
                    Number = "5",
                    Teacher = tMuhammed,
                    School = new School() { Code = 1004, Name = "Kayseri İlk Okulu" },
                    Lessons = new List<Lesson> {
                            new Lesson() { Code = 2000, Name = "Matematik", Vize = 10, Final = 0 },
                            new Lesson() { Code = 2001, Name = "Fizik", Vize = 10, Final = 100 },
                    },
                    Gender = Gender.Male
                }
            };


            foreach (Student st in studentList)
            {
                foreach (Lesson les in st.Lessons)
                {
                    //double Ortalama = les.Vize * 0.4 + les.Final * 0.6;
                    double Ortalama = les.Average;
                }
            }
        }
    }

    //Okul otomasyonu 
    //Student,Teacher,Lesson,Exam...

    public class Student : Person
    {
        public string Number { get; set; }
        public Teacher Teacher { get; set; } //Navigation Property 
        public List<Lesson> Lessons { get; set; }
        public School School { get; set; }
    }

    public class Teacher : Person
    {


    }

    public class Person
    {
        public string Name { get; set; } = "Mehmet";
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; } = new DateTime(1995, 1, 1);

        public Gender Gender { get; set; } = Gender.Male;
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class Lesson : SchoolLesson
    {
        private int PassedAverage = 60;

        public double Vize { get; set; }
        public double Final { get; set; }

        public double Average
        {
            get
            {
                return Vize * 0.4 + Final * 0.6;
            }
        }

        public string IsPassedOrNot
        {
            get
            {
                return Average >= PassedAverage ? "Başarılı" : "Başarısız";
                //Ternary If 
            }

        }


    }

    public class School : SchoolLesson
    {

    }

    public class SchoolLesson
    {
        public int Code { get; set; }
        public string Name { get; set; }

    }
}
