using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Core.ProductPortalBase.Hash
{
    public interface IBCryptHelper
    {
        bool Verify(string text, string hash, bool enhancedEntropy = true, HashType hashType = HashType.SHA512);

        string GenerateSalt(int workFactor, char bcryptMinorRevision = 'a');

        string HashPassword(string inputKey, string salt, bool enhancedEntropy = true, HashType hashType = HashType.SHA512);
    }
}
