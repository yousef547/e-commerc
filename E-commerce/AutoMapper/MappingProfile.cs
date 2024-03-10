using AutoMapper;
using E_commerce.Model;
using E_commerce.ViewModel;
using System.Text.Json;

namespace E_commerce.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductSize, SizeProductViewModel>()
                .ForMember(dest => dest.size, opt => opt.MapFrom(src => src.Size.size));

            CreateMap<ProductColor, ColorProductViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Color.Name))
                .ForMember(dest => dest.NameEn, opt => opt.MapFrom(src => src.Color.NameEn))
                .ForMember(dest => dest.ColorCode, opt => opt.MapFrom(src => src.Color.ColorCode));
                ;
            CreateMap<TbProduct, ProductViewModel>() ;
            CreateMap<TbCatagery, CategoryViewModel>();
        }

        #region Helper
      
        #endregion
    }
}
