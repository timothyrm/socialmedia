using System.Collections.Generic;
using System.Linq;
using socialmedia.models;
using socialmedia.Services.IStudentServices;
using socialmedia.Services.StudentServices;

namespace socialmedia.Services.StudentServices
{
    public  class  StudentService : IStudentService
    {
        private static List<Student> studentLista = new List<Student>() {
            new Student() {id = 1, name="Tim", classStudent=StudentClass.TE19D},
            new Student() {id = 2, name = "Albert", classStudent = StudentClass.TE19C}
        };

    private readonly DataContext _context;
    public StudentService(DataContext context)
    {
        _context = context;
    }

        public List<Student> GetStudentList() 
        {
            
            return _context.students.ToList();
        }

        public List<Student> AddStudent(Student newStudent) {
            _context.students.Add(newStudent);
            _context.SaveChanges();
            return _context.students.ToList();
        }


        public  List<Student> DeleteStudent(int id) {
            var hittadStudent =  _context.students.FirstOrDefault(s => s.id == id);
            _context.students.Remove(hittadStudent);
            _context.SaveChanges();

            return _context.students.ToList();
        }
        public List<Student> UpdateStudent(Student updateStudent){
            var hittadStudent = _context.students.FirstOrDefault(student=> student.id == updateStudent.id);

            if(hittadStudent != null){
                hittadStudent.name = updateStudent.name;
                hittadStudent.age = updateStudent.age;

            }
            _context.SaveChanges();
            return _context.students.ToList();
        }
      
    }
}