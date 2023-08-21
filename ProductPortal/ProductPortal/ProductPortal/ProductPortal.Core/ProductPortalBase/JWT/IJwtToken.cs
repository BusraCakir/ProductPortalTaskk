namespace ProductPortal.Core.ProductPortalBase.JWT
{
    public interface IJwtToken
    {
        JwtTokenOlustur TokenOlustur(TokenOlusturDto tokenOlusturDto);
    }
}
