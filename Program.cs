namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsManager = new StudentsManager();

            studentsManager[0] = new Student("Hamza");
            studentsManager[1] = new Student("Eslam");

            Console.WriteLine("Student Name for Index { 0 } :" + studentsManager[0].Name);
            Console.WriteLine("Student Name for Index { 1 } :" + studentsManager[1].Name);

        }
    }

    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }
    public class StudentsManager
    {
        private Student[] students = new Student[5];

        public Student this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }
    }


}
