using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDemo.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ClassId { get; set; }

        public DateTime Birthday { get; set; }

        [ForeignKey(nameof(Student.ClassId))]
        public Class Class { get; set; }


    }
}
