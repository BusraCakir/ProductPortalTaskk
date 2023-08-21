using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Urun.ItemDtos;
using ProductPortal.Domain.Dtos.Urun.QueryDtos;
using ProductPortal.Domain.IRepository.Urun;
using ProductPortal.Entity.Entities.Urun;

namespace ProductPortal.API.CQRS.Urun.Queries
{
    public class GetByIdUrunQueryHandler : ProductPortalHandlerBase<GetByIdUrunQueryHandler, GetByIdUrunQueryRequest, GetByIdUrunQueryResponse, IUrunRepository>
    {
        public GetByIdUrunQueryHandler() : base() { }
        public override async Task<GetByIdUrunQueryResponse> Handle(GetByIdUrunQueryRequest request, CancellationToken cancellationToken)
        {
            UrunEntity entity = await Repository.Get(urun => urun.Id == request.Id);
            if (entity == null)
                throw new ProductPortalException("Ürün getirilirken bir hata oluştu. Ürün bulunamadı.");

            UrunItemDto result = Map<UrunItemDto>(entity);
            return new GetByIdUrunQueryResponse() { Data = result };
        }
    }
}
