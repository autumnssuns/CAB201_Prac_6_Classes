using System;

namespace Student
{

    /// <summary>
    /// A class to model a student.
    /// </summary>
    class Student
    {
        /// <summary>
        /// The student's name.
        /// </summary>
        public string name { get; private set; }

        /// <summary>
        /// The student's number.
        /// </summary>
        public int number { get; private set; }


        /// <summary>
        /// The student's model.
        /// </summary>
        /// <param name="name">The student's name.</param>
        /// <param name="number">The student's number.</param>
        public Student(string name, int number)
        {
            this.name = name;
            this.number = number;
        }


        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Student eden = new Student("Eden", 10);
            Console.WriteLine(eden.name + " " + eden.number);

            Student helen = new Student("Helen", 11);
            Console.WriteLine(helen.name + " " + helen.number);

        }
    }
}