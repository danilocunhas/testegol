using Microsoft.EntityFrameworkCore;
using Teste.GOL.Domain.Entities;
using Teste.GOL.Infra.Persistence.Map;

namespace Teste.GOL.Infra.Persistence.ORM.DataContexts
{
    public class TesteGOLContext : DbContext
    {
        public TesteGOLContext() { }

        public TesteGOLContext(DbContextOptions<TesteGOLContext> options)
            : base(options)
        {

        }

        public virtual DbSet<AirPlane> AirPlanes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            new AirPlaneMap(modelBuilder.Entity<AirPlane>());

        }
    }
}
