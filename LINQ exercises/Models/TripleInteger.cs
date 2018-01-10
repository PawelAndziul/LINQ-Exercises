using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_exercises.Models
{
    public class TripleInteger
    {
        public TripleInteger(int firstValue, int secondValue, int thirdValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            ThirdValue = thirdValue;
        }

        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public int ThirdValue { get; set; }

       
    }
}
