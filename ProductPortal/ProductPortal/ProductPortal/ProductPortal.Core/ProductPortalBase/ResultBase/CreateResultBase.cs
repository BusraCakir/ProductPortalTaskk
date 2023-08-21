using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Core.ProductPortalBase.ResultBase
{
    public class CreateResultBase<TIdType> : ResultBase
    {
        public CreateResultBase() { }
        public TIdType Id { get; set; }
    }
}
