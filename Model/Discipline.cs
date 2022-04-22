using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Discipline
    {
        private int _mark;
        
        public Discipline()
        {

        }

        public Discipline(string teacher, string student, int mark)
        {
            Mark = mark;
            Teacher = teacher;
            Student = student;
        }
        public string Teacher { get; set; }
        public string Student { get; set; }
        public int Mark 
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 1 | value > 5)
                {
                    throw new ArgumentException("Оценка должна быть в пределе от 1 до 5");
                }
                _mark = value;
            }
        }
    }

    
}
