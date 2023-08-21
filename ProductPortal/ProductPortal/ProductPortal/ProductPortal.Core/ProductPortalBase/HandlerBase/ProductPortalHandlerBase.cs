using AutoMapper;
using DevExtreme.AspNet.Data;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductPortal.Core.Tool;

namespace ProductPortal.Core.ProductPortalBase.HandlerBase
{
    public class ProductPortalHandlerBase<THandler, TRequest, TResponse, TRepository> : ProductPortalBase<THandler>, IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        protected readonly IMapper _mapper;
        protected readonly TRepository Repository;

        public ProductPortalHandlerBase() : base()
        {
            _mapper=ServiceTool.ServiceProvider.GetService<IMapper>();
            Repository=ServiceTool.ServiceProvider.GetService<TRepository>();
        }
        public T Map<T>(object source)
        {
            var result = _mapper.Map<T>(source);
            return result;
        }
        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            var result= _mapper.Map<TSource, TDestination>(source, destination);
            return result;
        }
        public virtual Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            return null;
        }
        public LoadOptions DevExSetDefaultFilter(LoadOptions loadOptions, string selector, bool desc = true)
        {
            loadOptions.Filter.RemoteGrouping = true;
            loadOptions.Filter.RemoteSelect = true;
            loadOptions.Filter.StringToLower = true;
            if (loadOptions.Filter.Sort == null)
            {
                loadOptions.Filter.Sort = new SortingInfo[]
               {
                        new SortingInfo
                        {
                            Desc = desc,
                            Selector = selector,
                        }

               };
            }
            return loadOptions;
        }
    }
}
