using Models.Entities;
using System.Collections.Generic;


/**
* @author - Michael Mushynskyi
*
* @date - 10/27/2019 5:42:20 AM 
*/

namespace Models.Models
{
    public class StudentModel
    {
        private List<Student> _students;
        public StudentModel()
        {
            _students = new List<Student>();
        }
        public Student Add(int id, string name, int age)
        {
            Student stud = new Student(id, name, age);
            _students.Add(stud);
            return stud;
        }
        public Student Change(int id, string name, int age)
        {
            Student st = _students.Find(s => s.Id == id);
            if(st != null)
            {
                st.Name = name;
                st.Age = age;
            }
            return st;
        }
        public Student Remove(int id)
        {
            Student st = _students.Find(s => s.Id == id);
            _students.Remove(st);
            return st;
        }
        public Student Get(int id)
        {
            return _students.Find(s => s.Id == id);
        }
        public List<Student> GetAll()
        {
            return _students;
        }
    }
}
