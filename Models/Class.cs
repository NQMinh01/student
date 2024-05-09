using System.ComponentModel.DataAnnotations;

namespace StudentDemo.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
