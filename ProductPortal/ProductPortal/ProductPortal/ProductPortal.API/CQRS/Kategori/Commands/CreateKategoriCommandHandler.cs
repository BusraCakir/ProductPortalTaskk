using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Domain.Dtos.Kategori.CommandDtos;
using ProductPortal.Domain.IRepository.Kategori;
using ProductPortal.Entity.Core.BaseEntity;
using ProductPortal.Entity.Entities.Kategori;

namespace ProductPortal.API.CQRS.Kategori.Commands
{
    public class CreateKategoriCommandHandler : ProductPortalHandlerBase<CreateKategoriCommandHandler, CreateKategoriCommandRequest, CreateKategoriCommandResponse, IKategoriRepository>
    {
        public CreateKategoriCommandHandler() : base() { }
        public override async Task<CreateKategoriCommandResponse> Handle(CreateKategoriCommandRequest request, CancellationToken cancellationToken)
        {
            KategoriEntity entity = Map<KategoriEntity>(request);
            entity = UpsertBaseInfosToEntity<KategoriEntity>.ForInsert(entity, CurrentUser, false);
            bool result = await Repository.Add(entity);
            if (!result)
                throw new ProductPortalException("Kayıt Eklenirken Bir Hata Oluştu");

            return new CreateKategoriCommandResponse() { Id = entity.Id, Message = "Kayıt Başarıyla Eklendi" };
        }
    }
}
