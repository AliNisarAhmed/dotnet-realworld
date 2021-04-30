using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
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
		private IMapper _mapper;

		public ArticlesController(IRepositoryManager repo, IMapper mapper)
		{
			_repo = repo;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult GetArticles()
		{
			var articles = _repo.Article.GetAllArticles(trackChanges: false);

			var articlesDto = _mapper.Map<IEnumerable<ArticleDTO>>(articles);

			return Ok(new { articles = articlesDto });

		}
	}
}