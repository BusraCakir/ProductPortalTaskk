using AutoMapper;
using ProductPortal.Domain.Dtos.Kategori.CommandDtos;
using ProductPortal.Domain.Dtos.Kategori.ItemDtos;
using ProductPortal.Domain.Dtos.Kullanici.CommandDtos;
using ProductPortal.Domain.Dtos.Kullanici.ItemDtos;
using ProductPortal.Domain.Dtos.Marka.CommandDtos;
using ProductPortal.Domain.Dtos.Marka.ItemDtos;
using ProductPortal.Domain.Dtos.Model.CommandDtos;
using ProductPortal.Domain.Dtos.Model.ItemDtos;
using ProductPortal.Domain.Dtos.Urun.CommandDtos;
using ProductPortal.Domain.Dtos.Urun.ItemDtos;
using ProductPortal.Entity.Entities.Kategori;
using ProductPortal.Entity.Entities.Kullanici;
using ProductPortal.Entity.Entities.KullaniciYetki;
using ProductPortal.Entity.Entities.Marka;
using ProductPortal.Entity.Entities.Model;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.Infrastructure.AutoMapperHelper
{
    public class ProductPortalMapperProfile : Profile
    {
        public ProductPortalMapperProfile()
        {
            CreateMap<KullaniciEntity, CreateKullaniciCommandRequest>().ReverseMap();
            CreateMap<KullaniciEntity, UpdateKullaniciCommandRequest>().ReverseMap();
            CreateMap<KullaniciEntity, KullaniciItemDto>().ReverseMap();

            CreateMap<UrunEntity, CreateUrunCommandRequest>().ReverseMap();
            CreateMap<UrunEntity, UpdateUrunCommandRequest>().ReverseMap();
            CreateMap<UrunEntity, UrunItemDto>().ReverseMap();

            CreateMap<ModelEntity, CreateModelCommandRequest>().ReverseMap();
            CreateMap<ModelEntity, UpdateModelCommandRequest>().ReverseMap();
            CreateMap<ModelEntity, ModelItemDto>().ReverseMap();

            CreateMap<MarkaEntity, CreateMarkaCommandRequest>().ReverseMap();
            CreateMap<MarkaEntity, UpdateMarkaCommandRequest>().ReverseMap();
            CreateMap<MarkaEntity, MarkaItemDto>().ReverseMap();

            CreateMap<KategoriEntity, CreateKategoriCommandRequest>().ReverseMap();
            CreateMap<KategoriEntity, UpdateKategoriCommandRequest>().ReverseMap();
            CreateMap<KategoriEntity, KategoriItemDto>().ReverseMap();

        }
    }
}
 