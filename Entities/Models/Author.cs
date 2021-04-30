using System;
using System.Collections.Generic;

namespace Entities.Models
{
	public class Author
	{
		public Guid Id { get; set; }

		public string Username { get; set; }
		public string Bio { get; set; }
		public string Image { get; set; }

		public ICollection<Article> Articles { get; set; }

		// public int Following { get; set; }

	}
}