using System.Collections.Generic;
using socialmedia.models;

namespace socialmedia.Services.IStudentServices
{
    public interface IStudentService
    {
        //1: Hämta alla studenter som finns i systemet.
        List<Student> GetStudentList();

        //2: Skapa en metod som lägger till en ny student
        List<Student> AddStudent(Student newStudent);
         
         //3: Skapa en metod som tar bort en student
        List<Student> DeleteStudent(int id);
    }
}