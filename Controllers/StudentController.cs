using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using socialmedia.models;
using socialmedia.Services.IStudentServices;
using socialmedia.Services.StudentServices;

namespace socialmedia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public ActionResult<List<Student>> GetStudents() {
          
            return Ok(_studentService.GetStudentList());
        }
        //1: 
         [HttpPost]
         public ActionResult<List<Student>> AddStudent(Student newStudent) {
             return Ok(_studentService.AddStudent(newStudent));
         }


         [HttpDelete]
         public ActionResult<List<Student>> DeleteStudent(int id) {
             return Ok(_studentService.DeleteStudent(id));
         }
    }
}