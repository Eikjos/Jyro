using AutoMapper;
using Jyro.API.Model.User.Register;
using Jyro.Core.Entities;

namespace Jyro.API.Profiles
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<RegisterModel, User>();
		}
	}
}

