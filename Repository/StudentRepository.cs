using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDemo.Controllers;
using StudentDemo.Data;
using StudentDemo.Models;

namespace StudentDemo.Repository
{
    public class StudentRepository:IStudentInterface
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task addStudent(string name, DateTime birthday, int classId)
        {
            var newS = new Student
            {
                Name = name,
                Birthday = birthday,
                ClassId = classId
            };
            _context.Add(newS);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> getListStudent()
        {
            var list = _context.Students
                .Include(p=>p.Class)
                .ToList();
            return list;
        }
    }
}
