using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class About
	{
		[Key]
        public int AboutId { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public string ImageUr2 { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string Title3 { get; set; }
		public string Title4 { get; set; }
    }
}
