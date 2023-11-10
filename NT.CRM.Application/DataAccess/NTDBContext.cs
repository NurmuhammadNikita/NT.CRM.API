using Microsoft.EntityFrameworkCore;

namespace NT.CRM.Application.DataAccess
{
    public class NTDBContext : DbContext
    {
        public NTDBContext(DbContextOptions<NTDBContext> options):base(options) { }
        
    }
}
