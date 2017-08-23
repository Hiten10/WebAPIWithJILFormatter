using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIWithJILFormatter.Filters;
using WebAPIWithJILFormatter.Models;
using WebAPIWithJILFormatter.Repository;

namespace WebAPIWithJILFormatter.Controllers
{
    public class StudentsController : ApiController
    {
        readonly IStudentRepository _students;
        public StudentsController(IStudentRepository student)
        {
            _students = student;
        }

        [DeflateCompression]
        // GET: api/Students
        public IHttpActionResult Get()
        {
            return Ok(_students.GetAllStudents());
        }

        // GET: api/Students/5
        public IHttpActionResult Get(int id)
        {
            return Ok(_students.GetById(id));
        }

        // POST: api/Students
        [DeflateCompression]
        public IHttpActionResult Post(Student student)
        {
            _students.Add(student);
            return Ok<Student>(student);
        }

        // PUT: api/Students/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
        }
    }
}
