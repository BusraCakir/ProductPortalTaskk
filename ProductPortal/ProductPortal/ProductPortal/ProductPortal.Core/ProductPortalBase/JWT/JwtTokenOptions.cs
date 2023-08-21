namespace ProductPortal.Core.ProductPortalBase.JWT
{
    public class JwtTokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string SecurityKey { get; set; }
        public int Expiration { get; set; }
    }
}
