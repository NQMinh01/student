using Microsoft.AspNetCore.Mvc;
using StudentDemo.Models;

namespace StudentDemo.Repository
{
    public interface IStudentInterface
    {
        public Task<List<Student>> getListStudent();
        public Task addStudent(string name, DateTime birthday, int classId);
    }
}
