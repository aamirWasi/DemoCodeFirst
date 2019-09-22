using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public CourseLevel CourseLevel { get; set; }
        public double Price { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}
