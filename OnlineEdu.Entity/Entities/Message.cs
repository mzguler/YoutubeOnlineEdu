using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class Message
	{
        [Key]
        public int MessageId { get; set; }
        public string MessageName { get; set; }
        public string Email { get; set; }
        public  string Subject { get; set; }
        public  string Content { get; set; }

    }
}
