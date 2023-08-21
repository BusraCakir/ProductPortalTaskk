using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProductPortal.Core.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ProductPortal.Entity.Core.BaseEntity
{
    public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        protected readonly IMapper Mapper;
        public BaseConfiguration()
        {
            Mapper = ServiceTool.ServiceProvider.GetService<IMapper>();
        }
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey("Id");
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedUser).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedUser).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired(true); // Aktiflik durumu pasif olan kayıtlara IsActive=false vermek gerekli.
        }
    }
}
