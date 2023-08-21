using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kullanici.ItemDtos;
using ProductPortal.Domain.Dtos.Kullanici.QueryDtos;
using ProductPortal.Domain.IRepository.Kullanici;
using ProductPortal.Entity.Entities.Kullanici;
using ProductPortal.Infrastructure.Repository.Kullanici;

namespace ProductPortal.API.CQRS.Kullanici.Queries
{
    public class GetByIdKullaniciQueryHandler : ProductPortalHandlerBase<GetByIdKullaniciQueryHandler, GetByIdKullaniciQueryRequest, GetByIdKullaniciQueryResponse, IKullaniciRepository>
    {
        public GetByIdKullaniciQueryHandler() : base() { }
        public override async Task<GetByIdKullaniciQueryResponse> Handle(GetByIdKullaniciQueryRequest request, CancellationToken cancellationToken)
        {
            KullaniciEntity entity = await Repository.Get(kullanici => kullanici.Id == request.Id);
            if (entity == null)
                throw new ProductPortalException("Kullanici getirilirken bir hata oluştu. Kullanici bulunamadı.");

            KullaniciItemDto result = Map<KullaniciItemDto>(entity);
            return new GetByIdKullaniciQueryResponse() { Data = result };
        }
    }
}
