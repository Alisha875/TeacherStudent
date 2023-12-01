
namespace TeacherStudent
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public void FillWithDummyData()
        {
            Name = "John Doe";
            Class = "10";
            Section = "A";
        }
    }
}
