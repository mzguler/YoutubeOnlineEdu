using Microsoft.EntityFrameworkCore;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Context
{
	public class OnlineEduContext : DbContext


	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=ABL000299-0036;initial catalog=OnlineEduMzg;integrated security = true");
				} 
	    
		/**public OnlineEduContext(DbContextOptions options) : base(options)
		{

		}
		**/
		public DbSet<About>Abouts { get; set; }
		public DbSet<Banner> Banners { get; set; }
		public DbSet<Blog>Blogs { get; set; }
		public DbSet<BlogCategory>BlogCategories { get; set; }
		public DbSet<Contact>Contacts { get; set; }
		public DbSet<Course>Courses { get; set; }
		public DbSet<CourseCategory>CourseCategories { get; set; }
		public DbSet<Message>Messages { get; set; }
		public DbSet<SocialMedia>SocialMedias { get; set; }
		public DbSet<Subscribe>Subscribes { get; set; }
		public DbSet<Testimonial>Testimonials { get; set; }
	}
}
