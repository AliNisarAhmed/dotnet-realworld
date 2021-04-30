using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities.DTO;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RealWorld.Controllers
{
	[ApiController]
	[Route("api/articles")]
	public class ArticlesController : ControllerBase
	{
		private IRepositoryManager _repo;

		public ArticlesController(IRepositoryManager repo)
		{
			_repo = repo;
		}

		[HttpGet]
		public IActionResult GetArticles()
		{
			var articles = _repo.Article.GetAllArticles(trackChanges: false);

			return Ok(new { articles });

		}
	}
}