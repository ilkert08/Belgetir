using Belgetir.Entities;
using Microsoft.EntityFrameworkCore;

namespace Belgetir.DAL
{
    public class DocumentContext : DbContext
    {
        public DbSet<Document> documents { get; set; }

        public DocumentContext(DbContextOptions<DocumentContext> options) : base(options)
        {

        }

    }
}
