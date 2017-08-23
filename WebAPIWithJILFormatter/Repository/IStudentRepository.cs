using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIWithJILFormatter.Models;

namespace WebAPIWithJILFormatter.Repository
{
    public interface IStudentRepository
    {
        void Add(Student student);
        Student GetById(int studentID);
        IEnumerable<Student> GetAllStudents();
        void Edit(Student student);
        void Remove(int studentID);

    }
}
