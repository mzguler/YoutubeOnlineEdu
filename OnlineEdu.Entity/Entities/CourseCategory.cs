using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class CourseCategory
	{
        [Key]
        public int CourseCategoryId { get; set; }
        public string CourseCategoryName { get; set; }
        public string İcon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
    }
}
