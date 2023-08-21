using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Marka.ItemDtos;
using ProductPortal.Domain.Dtos.Marka.QueryDtos;
using ProductPortal.Domain.IRepository.Marka;
using ProductPortal.Entity.Entities.Marka;

namespace ProductPortal.API.CQRS.Marka.Queries
{
    public class GetByIdMarkaQueryHandler : ProductPortalHandlerBase<GetByIdMarkaQueryHandler, GetByIdMarkaQueryRequest, GetByIdMarkaQueryResponse, IMarkaRepository>
    {
        public GetByIdMarkaQueryHandler() : base() { }
        public override async Task<GetByIdMarkaQueryResponse> Handle(GetByIdMarkaQueryRequest request, CancellationToken cancellationToken)
        {
            MarkaEntity entity = await Repository.Get(marka => marka.Id == marka.Id);
            if (entity == null)
                throw new ProductPortalException("Marka getirilirken bir hata oluştu. Marka bulunamadı.");

            MarkaItemDto result = Map<MarkaItemDto>(entity);
            return new GetByIdMarkaQueryResponse() { Data = result };
        }
    }
}
