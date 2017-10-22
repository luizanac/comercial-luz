using AutoMapper;
using ContaLuz.Domain;
using ContaLuz.Models;

namespace ContaLuz
{
	public class Mapping : Profile
	{
		public Mapping()
		{
			CreateMap<Conta, ContaViewModel>();
			CreateMap<ContaViewModel, Conta>();
			
			
		}
	}
}