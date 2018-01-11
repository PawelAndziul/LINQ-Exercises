using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_exercises.Models
{
    public class Student
    {
        public Student(int id, string name, int points)
        {
            Id = id;
            Name = name;
            Points = points;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

    }
}
