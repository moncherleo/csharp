using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Teacher : Person
    {
        private String university;
        public Teacher(String name, String university)
            : base (name)
        {
            this.university = university;
        }
        public String LessonFinished()
        {
            return "Do not forget to make homework!";
        }
    }
}
