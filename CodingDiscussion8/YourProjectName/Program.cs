using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Course objects
            Course[] courses = new Course[]
            {
                new Course("IT 145"),
                new Course("IT 200"),
                new Course("IT 201"),
                new Course("IT 270"),
                new Course("IT 315"),
                new Course("IT 328"),
                new Course("IT 330")
            };

            Console.WriteLine("Teacher's Copy");
            Console.WriteLine("List of courses:");

            // Iterate over the array and print each course name
            foreach (var course in courses)
            {
                Console.WriteLine(course.GetName());
            }
        }
    }

    class Course
    {
        private string name = "";

        public Course(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
