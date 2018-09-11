using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            var userInput = string.Empty;
            char c = Convert.ToChar(Console.ReadLine());

            static void namesList()
            {

            
                while (userInput != "q")
            {
                Console.Write("Please enter a name to add to the list: ");
                userInput = Console.ReadLine();
                if (userInput != "q")
                    names.Add(userInput);
            }

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            }

            Dictionary<string, string> studentsGrades = new Dictionary<string, string>();
            string name = string.Empty;
            string grade = string.Empty;

            do
            {
                Console.Write("Enter a name: ");
                name = Console.ReadLine();
                if (name != "q")
                {
                    Console.Write($"Enter {name} grade: ");
                    grade = Console.ReadLine();
                    studentsGrades.Add(name, grade);
                }
            } while (name != "q");

            Console.WriteLine("Printout WayI");
            foreach (var pair in studentsGrades)
            {
                Console.WriteLine(pair);
            }

            Console.WriteLine("Printout WayII");
            foreach (KeyValuePair<string, string> pair in studentsGrades)
            {
                Console.WriteLine($"student {pair.Key} get {pair.Value}");
            }










            //    List<Student> ListofStudents = new List<Student>();

            //    Student objStudent = new Student();
            //    objStudent.CustomProperties.Add("Name: ", "Mike");
            //    objStudent.CustomProperties.Add("Grade: ", 'A');

            //    ListofStudents.Add(objStudent);

            //    objStudent = new Student();
            //    objStudent.CustomProperties.Add("Name: ", "Terry");
            //    objStudent.CustomProperties.Add("Grade: ", 'A');

            //    ListofStudents.Add(objStudent);

            //    objStudent = new Student();
            //    objStudent.CustomProperties.Add("Name: ", "Paul");
            //    objStudent.CustomProperties.Add("Grade: ", 'A');

            //    ListofStudents.Add(objStudent);

            //    objStudent = new Student();
            //    objStudent.CustomProperties.Add("Name: ", "Rahel");
            //    objStudent.CustomProperties.Add("Grade: ", 'A');

            //    ListofStudents.Add(objStudent);

            //    objStudent = new Student();
            //    objStudent.CustomProperties.Add("Name: ", "Shilpa");
            //    objStudent.CustomProperties.Add("Grade: ", 'A');

            //    ListofStudents.Add(objStudent);

            //    objStudent = new Student();
            //    objStudent.CustomProperties.Add("Name: ", "Salah");
            //    objStudent.CustomProperties.Add("Grade: ", 'F');

            //    ListofStudents.Add(objStudent);

            //    foreach (Student currentStudent in ListofStudents)
            //    {
            //        foreach (var prop in currentStudent.CustomProperties)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine(prop.Key + " " + prop.Value);
            //        }

            //    }
            //}

            //public class Student
            //{
            //    private readonly Dictionary<string, object> _customProperties = new Dictionary<string, object>();

            //    public Dictionary<string, object> CustomProperties { get { return _customProperties; } }
            //}




        }
    }


}
