using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    public class Teacher
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }

        public void FillWithDummyData()
        {
            Name = "Jane Smith";
            Subjects = new List<Subject>
        {
            new Subject { Name = "Math" },
            new Subject { Name = "Science" }
        };
        }
    }
}
