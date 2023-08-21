using ProductPortal.Core.ProductPortalBase.JWT;
using ProductPortal.Core.ProductPortalBase.ResultBase;

namespace ProductPortal.Domain.Dtos.Kategori.CommandDtos
{
    public class LoginCommandResponse : CreateResultBase<Guid>
    {
        public JwtTokenOlustur JwtTokenOlustur { get; set; }
    }
}
