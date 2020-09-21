using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace RadixS.Farmers.Direct.EntityFrameworkCore
{
    public static class DirectDbContextModelCreatingExtensions
    {
        public static void ConfigureDirect(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DirectConsts.DbTablePrefix + "YourEntities", DirectConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}