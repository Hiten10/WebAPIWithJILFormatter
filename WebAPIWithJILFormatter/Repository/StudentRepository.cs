using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIWithJILFormatter.Models;

namespace WebAPIWithJILFormatter.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private static readonly List<Student> _students = new List<Student>();

        public StudentRepository()
        {
           // _students = new List<Student>();
        }
        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Edit(Student student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetById(int studentID)
        {
            return _students.Where(s => s.StudentID == studentID).FirstOrDefault();
        }

        public void Remove(int studentID)
        {
            throw new NotImplementedException();
        }
    }
}