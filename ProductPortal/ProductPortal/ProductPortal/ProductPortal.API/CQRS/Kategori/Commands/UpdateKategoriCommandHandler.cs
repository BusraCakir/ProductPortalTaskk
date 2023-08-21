using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kategori.CommandDtos;
using ProductPortal.Domain.IRepository.Kategori;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Kategori;

namespace ProductPortal.API.CQRS.Kategori.Commands
{
    public class UpdateKategoriCommandHandler : ProductPortalHandlerBase<UpdateKategoriCommandHandler, UpdateKategoriCommandRequest, UpdateKategoriCommandResponse, IKategoriRepository>
    {
        public UpdateKategoriCommandHandler() : base() { }
        public override async Task<UpdateKategoriCommandResponse> Handle(UpdateKategoriCommandRequest request, CancellationToken cancellationToken)
        {
            var hediye = Map<KategoriEntity>(request);
            hediye = UpsertBaseInfosToEntity<KategoriEntity>.ForUpdate(hediye, CurrentUser, request.IsActive);
            bool result = await Repository.Update(hediye);

            if (!result)
                throw new ProductPortalException("Kategori güncellenirken bir hata oluştu!");

            return new UpdateKategoriCommandResponse() { Message = "Kategori başarıyla güncellendi!" };
        }
    }
}
