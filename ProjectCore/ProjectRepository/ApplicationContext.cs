using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectRepository
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<Product>());
            new ProductDetailMap(modelBuilder.Entity<ProductDetails>());
        }

        class ProductDetailMap
        {
            public ProductDetailMap(EntityTypeBuilder<ProductDetails> entityBuilder)
            {
                entityBuilder.HasKey(p => p.ProductId);
                entityBuilder.Property(p => p.StockAvailable).IsRequired();
                entityBuilder.Property(p => p.Price);
            }
        }

        class ProductMap
        {
            private readonly EntityTypeBuilder<Product>
#pragma warning disable IDE0052 // Remove unread private members
                entityTypeBuilder;
#pragma warning restore IDE0052 // Remove unread private members

            public ProductMap(EntityTypeBuilder<Product> entityTypeBuilder)
            {
                this.entityTypeBuilder = entityTypeBuilder;
            }
        }

        class ProductDetails : BaseEntity
        {
            public int StockAvailable { get; set; }
            public decimal Price { get; set; }
            public virtual Product Product { get; set; }
        }
    }
}
