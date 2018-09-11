using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyBusiness
{
    class GradeBook
    {
        private string[] studentName = {"John", "Aiden", "Ashley"};
        private char[] letterGrade = {'C', 'B', 'A'};
        private int[] numberGrade = {75, 88, 97};

        public double gradeAvg()
        {
            string grade;
            if (numberGrade >= 90 && percentageMark <= 100)
                letterGrade = "A";
            else if (numberGrade >= 80)
                letterGrade = "B";
            else if (numberGrade >= 70)
                letterGrade = "C";
            else if (numberGrade >= 60)
                letterGrade = "D";
            else if (numberGrade >= 50)
                letterGrade = "F";
        }

        public string Students()
        {

        }
    }
}
