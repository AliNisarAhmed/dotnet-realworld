using AutoMapper;
using Entities.DTO;
using Entities.Models;

namespace RealWorld
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Article, ArticleDTO>()
			.ForMember(c => c.CreatedAt,
					opt => opt.MapFrom(art => art.CreatedAt.ToString("o")))
			.ForMember(c => c.UpdatedAt,
					opt => opt.MapFrom(art => art.UpdatedAt.ToString("o")));
		}
	}
}