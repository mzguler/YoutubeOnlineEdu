﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class SocialMedia
	{
		[Key]
        public int SocialMediaId { get; set; }
		public string Icon { get; set; }
		public string ImageUrl { get; set; }
		public string Title { get; set; }	
    }
}
