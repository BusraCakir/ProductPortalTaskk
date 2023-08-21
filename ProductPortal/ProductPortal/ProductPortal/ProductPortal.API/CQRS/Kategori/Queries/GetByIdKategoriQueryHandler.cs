using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kategori.ItemDtos;
using ProductPortal.Domain.Dtos.Kategori.QueryDtos;
using ProductPortal.Domain.IRepository.Kategori;
using ProductPortal.Entity.Entities.Kategori;

namespace ProductPortal.API.CQRS.Kategori.Queries
{
    public class GetByIdKategoriQueryHandler : ProductPortalHandlerBase<GetByIdKategoriQueryHandler, GetByIdKategoriQueryRequest, GetByIdKategoriQueryResponse, IKategoriRepository>
    {
        public GetByIdKategoriQueryHandler() : base() { }
        public override async Task<GetByIdKategoriQueryResponse> Handle(GetByIdKategoriQueryRequest request, CancellationToken cancellationToken)
        {
            KategoriEntity entity = await Repository.Get(kategori => kategori.Id == request.Id);
            if (entity == null)
                throw new ProductPortalException("Kategori getirilirken bir hata oluştu. Kategori bulunamadı.");

            KategoriItemDto result = Map<KategoriItemDto>(entity);
            return new GetByIdKategoriQueryResponse() { Data = result };
        }
    }
}
