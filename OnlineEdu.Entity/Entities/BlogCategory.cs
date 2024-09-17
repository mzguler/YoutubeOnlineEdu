using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class BlogCategory
	{
        [Key]
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
        public List<Blog> Blogs { get; set; }
        
    }
}
