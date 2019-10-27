using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
* @author - Michael Mushynskyi
*
* @date - 10/22/2019 3:53:25 AM 
*/

namespace Models.Entities
{
    public class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public const string OutputPattern = "|{0,-3}|{1,-14}|{2,-3}|\n";
        public const int LineLength = 20;
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format(OutputPattern, Id, Name, Age)+ "+---+--------------+---+\n";
        }
    }
}
