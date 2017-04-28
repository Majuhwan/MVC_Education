using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
	public class GuestResponse
	{
		[Required(ErrorMessage ="이름 입력 필수")]
		public string Name { get; set; }
		public string Email { get; set; }
		[Required(ErrorMessage = "전화번호 입력 필수")]
		public string Phone { get; set; }
		public bool? WillAttend { get; set; }
	}
}