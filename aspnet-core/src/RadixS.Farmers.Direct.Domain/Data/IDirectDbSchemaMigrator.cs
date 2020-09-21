using System.Threading.Tasks;

namespace RadixS.Farmers.Direct.Data
{
    public interface IDirectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
