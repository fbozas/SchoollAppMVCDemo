using System.Collections.Generic;

namespace SchoollAppMVCDemo.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
    }
}