using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserPassword.Models
{
    internal class Group
    {
        private int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get => _studentLimit; set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                }
            }
        }
        private List<Student> students = new List<Student>();
        public Group(string groupNo, int studentLimit)
        {
            students = new List<Student>();
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                    {
                        return false;
                    }
                    return true;
                }
            }
            return true;
        }

        public void AddStudent(Student student)
        {
            if (student != null && students.Count >= 0 && students.Count <= 18)
            {
                students.Add(student);
            }
        }

        public Student GetStudent(int? id)
        {
            if (id != null && students.Count > 0)
            {
                foreach (var student in students)
                {
                    if (student.Id == id)
                    {
                        return student;
                    }
                }
            }
            return null;
        }
        public List<Student>? GetAllStudents() => students ?? null;
    }
}
