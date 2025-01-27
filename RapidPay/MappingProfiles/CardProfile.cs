using AutoMapper;
using Models.Model.Api.Request;
using Models.Model.Api.Response;
using Models.Model.Data;

namespace RapidPay.MappingProfiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<CreateCardRequest, Card>();
            CreateMap<Card, CreateCardResponse>();
        }
    }
}