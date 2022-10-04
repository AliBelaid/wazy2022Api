using System;
using System.Linq;
using API.Helpers;
using AutoMapper;
using wazyApi.Dtos;
using wazyApi.Models;

namespace wazyApi.Helpers {
    public class MappingProfiles : Profile {
        public MappingProfiles () {
 
            CreateMap<smPictureDto,SmPicture>().ReverseMap();
             CreateMap<Product, ProductDto>().ReverseMap(); 
                CreateMap<Category, CategoryDto>().ReverseMap(); 
                   CreateMap<Brand, BrandDto>().ReverseMap(); 
                      CreateMap<Variant, VariantDto>().ReverseMap();   
                       CreateMap<Size, Dtos.SizeDto>().ReverseMap(); 
          CreateMap<PictureDto,Picture>().ReverseMap() ;
                CreateMap<Picture,Picture>().ForMember (x => x.url, o =>                 
               o.MapFrom (s => s.url)).ForMember (x => x.url, o =>
               o.MapFrom<PictureUrlResolver> ());
            CreateMap<SmPicture,SmPicture>().ForMember (x => x.url, o =>                 
               o.MapFrom (s => s.url)).ForMember (x => x.url, o =>
               o.MapFrom<SmPictureUrlResolver> ());
           
             //   o.MapFrom<ProductUrlResolver> ());
            //   CreateMap<Message, MessageDto> ().
            //   ForMember(des=>des.RecipientPhotoUrl , o=> o.MapFrom(i=>i.Recipient.Photos.FirstOrDefault(x=>x.IsMain).Url)).
            //     ForMember(des=>des.SenderPhotoUrl , o=> o.MapFrom(i=>i.Sender.Photos.FirstOrDefault(x=>x.IsMain).Url));
            // CreateMap<Product, ProductToReturnDto> ().ForMember (x => x.ProductBrand, o =>
            //     o.MapFrom (s => s.ProductBrand.Name)).ForMember (x => x.ProductType, o =>
            //     o.MapFrom (s => s.ProductType.Name)).ForMember (x => x.PictureUrl, o =>
            //     o.MapFrom<ProductUrlResolver> ());
            // CreateMap<Core.Entities.identity.Address, AddressDto> ().ReverseMap ();
            // CreateMap<CustomerBasketDto, CustomerBasket> ();
            // CreateMap<BasketItemDto, BasketItem> ();
            // CreateMap<AddressDto, Core.Entities.OrderAggregate.Address> ().ReverseMap ();

            // CreateMap<Order,OrderToReturnDto>().
            // ForMember(a=>a.DelivaryMethod, o=>o.MapFrom(s =>s.DelivaryMethod.ShortName)).
            //  ForMember(a=>a.ShippingPrice, o=>o.MapFrom(s =>s.DelivaryMethod.Price));
            // CreateMap<OrderItem,OrderItemDto>()
            // .ForMember(e =>e.PictureUrl, u =>u.MapFrom(o => o.ItemOrdered.PictureUrl))
            // .ForMember(e =>e.ProductId, u =>u.MapFrom(o => o.ItemOrdered.ProductItemId))
            // .ForMember(e =>e.ProductName, u =>u.MapFrom(o => o.ItemOrdered.ProductName))
            //         .ForMember(e =>e.PictureUrl, u =>u.MapFrom<OrderUrlResolver>()); 
        
              
            //       CreateMap<AppUser,Member>().
            //       ForMember(e=>e.PhotoUrl,u=>u.MapFrom(a=>a.Photos.SingleOrDefault(y=>y.IsMain).Url))
            //       .ForMember(t=> t.Age, y=>y.MapFrom(y=>y.DateOfBirth.CalculateAge())); 
            //         CreateMap<Photo,PhotoDto> ().ReverseMap(); 
            //     CreateMap<MemberUpdateDto,AppUser>();
            //       CreateMap<RegisterDto,AppUser>();
            //      CreateMap<DateTime,DateTime>().ConvertUsing(d=>DateTime.SpecifyKind(d,DateTimeKind.Utc));
        }
    }
}