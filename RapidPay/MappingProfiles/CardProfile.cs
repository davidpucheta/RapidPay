using AutoMapper;
using RapidPay.Model.Api.Request;
using RapidPay.Model.Api.Response;
using RapidPay.Model.Data;

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
