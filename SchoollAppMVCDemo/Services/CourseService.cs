using SchoollAppMVCDemo.Models;
using System.Collections.Generic;

namespace SchoollAppMVCDemo.Services
{
    public static class CourseService
    {
        public static List<Course> Courses { get; private set; }

        static CourseService()
        {
            Courses = new List<Course>()
            {
                new Course
                {
                    ID = 1,
                    Name = "Java",
                    Trainers = new List<Trainer>()
                    {
                        new Trainer(){FullName = "Nikos Papadopoulos"}
                    },
                    Students = new List<Student>()
                    {
                        new Student(){ID = 1, FullName = "Kostas Pappas"},
                        new Student(){ID = 2, FullName = "Nikos Panagou"}
                    }
                },

                new Course
                {
                    ID = 2,
                    Name = "C#",
                    Trainers = new List<Trainer>()
                    {
                        new Trainer(){FullName = "George Pasparakis"}
                    },
                    Students = new List<Student>()
                    {
                        new Student(){ID = 1, FullName = "Kostas Petropoulos"},
                        new Student(){ID = 2, FullName = "Nikos Chatzis"}
                    }
                }
            };
        }
    }
}