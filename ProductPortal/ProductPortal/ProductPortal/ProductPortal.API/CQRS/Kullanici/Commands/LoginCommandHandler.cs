using ProductPortal.Core.ProductPortalBase.Exception;
using ProductPortal.Core.ProductPortalBase.HandlerBase;
using ProductPortal.Core.ProductPortalBase.Hash;
using ProductPortal.Core.ProductPortalBase.JWT;
using ProductPortal.Domain.Dtos.Kategori.CommandDtos;
using ProductPortal.Domain.Dtos.KullaniciYetki.QueryDtos;
using ProductPortal.Domain.IRepository.Kullanici;

namespace ProductPortal.API.CQRS.Kullanici.Commands
{
    public class LoginCommandHandler : ProductPortalHandlerBase<LoginCommandHandler, LoginCommandRequest, LoginCommandResponse, IKullaniciRepository>
    {
        private readonly IJwtToken _jwtTokenHelper;
        private readonly IBCryptHelper _crptHelper;
        public LoginCommandHandler(IJwtToken jwtTokenHelper, IBCryptHelper crptHelper) : base()
        {
            _jwtTokenHelper = jwtTokenHelper;
            _crptHelper = crptHelper;
        }
        public override async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            var kullanici = await Repository.GetKullaniciByKullaniciAdiOrEpostaQuery(request.KullaniciAdi.Trim());
            if (kullanici == null)
                throw new ProductPortalException("Kullanıcı adı ve/veya şifre yanlış");

            bool verified = _crptHelper.Verify(request.Sifre, kullanici.Password);
            if (!verified)
                throw new ProductPortalException("Kullanıcı adı ve/veya şifre yanlış");

            var kullaniciYetkiResponse = await Mediator.Send(new GetAllAsListYetkiKodByKullaniciIdKullaniciYetkiQueryRequest() { KullaniciId = kullanici.Id });
            if (!kullaniciYetkiResponse.Status)
                throw new ProductPortalException($"{request.KullaniciAdi} kullanısının yetkileri getirilemedi.");

            TokenOlusturDto tokenOlusturDto = new()
            {
                KullaniciAdi = kullanici.Ad,
                KullaniciId = kullanici.Id,
                Email = kullanici.Email,
                YetkiKodList = kullaniciYetkiResponse.Data.Select(x => x.Kod).ToList()
    };

            var token = _jwtTokenHelper.TokenOlustur(tokenOlusturDto);
            await Repository.LastLoginDateUpdate(kullanici.Id);

            return new LoginCommandResponse() { JwtTokenOlustur = token };
        }
    }
}