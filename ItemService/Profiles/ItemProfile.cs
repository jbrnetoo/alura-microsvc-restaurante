using AutoMapper;
using ItemService.Dtos;
using ItemService.Models;

namespace ItemService.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<RestauranteReadDto, Restaurante>()
            .ForMember(dest => dest.IdExterno, opt => opt.MapFrom(src => src.Id))
            .ReverseMap();
            CreateMap<ItemCreateDto, Item>();
            CreateMap<Item, ItemCreateDto>();
            CreateMap<Item, ItemReadDto>();
        }
    }
}