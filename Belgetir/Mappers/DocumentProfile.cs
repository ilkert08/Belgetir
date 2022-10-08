using AutoMapper;
using Belgetir.Model;
using Belgetir.Models;
using Belgetir.Models.Requests;
using Belgetir.Models.Responses;

namespace Belgetir.Mappers
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<IDocument, Document>()
       .ForMember(
           dest => dest.Pdf,
           opt => opt.MapFrom(src => $"{src.Pdf}")
       )
       .ForMember(
           dest => dest.Name,
           opt => opt.MapFrom(src => $"{src.Name}")
       )
       .ReverseMap();

            CreateMap<StoreRequest, IDocument>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.name}")
                ); // No reverse map.



            CreateMap<IDocument, StoreResponse>()
                .ForMember(
                    dest => dest.name,
                    opt => opt.MapFrom(src => $"{src.Name}")
                ); // No reverse map.

        }
    }
}
