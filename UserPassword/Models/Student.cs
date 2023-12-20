using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPassword.Models
{
    internal class Student
    {
        //public Guid Id { get;private set; }
        private static int _id;
        public int Id { get;}
        public string Fullname { get; set; }
        public int Point { get; set; }

        public override string ToString()
        {
            return $"{Fullname} {Point}";
        }
        public Student(string fullname,int point)
        {
            _id++;
            Id = _id;
            Fullname= fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Student Id: {Id}  Student Fullname: {Fullname}  Student Point {Point}  ");
        }

    }    
}
