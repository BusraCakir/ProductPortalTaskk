using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ProductPortal.Core.ProductPortalBase.JWT
{
    public class JwtToken : IJwtToken
    {
        private readonly IConfiguration Configuration;
        private JwtTokenOptions _jwtTokenOptions;
        private DateTime _tokenExpiration;
        public JwtToken(IConfiguration configuration)
        {
            Configuration = configuration;
            _jwtTokenOptions = Configuration.GetSection("Token").Get<JwtTokenOptions>();

        }
        public JwtTokenOlustur TokenOlustur(TokenOlusturDto tokenOlusturDto)
        {
            _tokenExpiration = DateTime.Now.AddMinutes(_jwtTokenOptions.Expiration);
            var securityKey = SecurityKeyHelper.SecurityKeyOlustur(_jwtTokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.SigningCredentialsOlustur(securityKey);
            var jwt = JwtSecurityTokenOlustur(signingCredentials, tokenOlusturDto);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new JwtTokenOlustur()
            {
                AccessToken = token,
                Expiration = _tokenExpiration
            };
        }

        private JwtSecurityToken JwtSecurityTokenOlustur(SigningCredentials signingCredentials, TokenOlusturDto tokenOlusturDto)
        {
            var jwt = new JwtSecurityToken(issuer: _jwtTokenOptions.Issuer,
                                           audience: _jwtTokenOptions.Audience,
                                           expires: _tokenExpiration,
                                           notBefore: DateTime.Now,
                                           claims: SetClaims(tokenOlusturDto),
                                           signingCredentials: signingCredentials);

            return jwt;
        }

        private IEnumerable<Claim> SetClaims(TokenOlusturDto tokenOlusturDto)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Email, tokenOlusturDto.Email),
                new Claim(JwtRegisteredClaimNames.GivenName, tokenOlusturDto.KullaniciAdi),
                new Claim(JwtRegisteredClaimNames.GivenName, tokenOlusturDto.KullaniciSoyadi),
                new Claim(JwtRegisteredClaimNames.NameId, tokenOlusturDto.KullaniciId.ToString()),
                new Claim("yetkiJson", JsonConvert.SerializeObject(tokenOlusturDto.YetkiKodList))
            };
            return claims;
        }
    }
}
