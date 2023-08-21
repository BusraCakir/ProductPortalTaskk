using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Model.ItemDtos;
using ProductPortal.Domain.Dtos.Model.QueryDtos;
using ProductPortal.Domain.IRepository.Model;
using ProductPortal.Entity.Entities.Model;

namespace ProductPortal.API.CQRS.Model.Queries
{
    public class GetByIdModelQueryHandler : ProductPortalHandlerBase<GetByIdModelQueryHandler, GetByIdModelQueryRequest, GetByIdModelQueryResponse, IModelRepository>
    {
        public GetByIdModelQueryHandler() : base() { }
        public override async Task<GetByIdModelQueryResponse> Handle(GetByIdModelQueryRequest request, CancellationToken cancellationToken)
        {
            ModelEntity entity = await Repository.Get(model => model.Id == request.Id);
            if (entity == null)
                throw new ProductPortalException("Model getirilirken bir hata oluştu. Model bulunamadı.");

            ModelItemDto result = Map<ModelItemDto>(entity);
            return new GetByIdModelQueryResponse() { Data = result };
        }
    }
}
