using System;

namespace Entities.DTO
{
	public class AuthorDTO
	{
		public Guid AuthorId { get; set; }

		public string Username { get; set; }
		public string Bio { get; set; }
		public string Image { get; set; }

	}
}