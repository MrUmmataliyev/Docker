using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Domain.Models
{
    public class CourseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartedDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }
    }
}
