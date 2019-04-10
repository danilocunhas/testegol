using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.GOL.Domain.Entities;

namespace Teste.GOL.Infra.Persistence.Map
{
    public class AirPlaneMap
    {
        public AirPlaneMap(EntityTypeBuilder<AirPlane> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.ToTable("AirPlane");
            entityBuilder.Property(t => t.Id).HasColumnName("Id");
            entityBuilder.Property(t => t.Code).HasColumnName("Code");
            entityBuilder.Property(t => t.Model).HasColumnName("Model");
            entityBuilder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            entityBuilder.Property(t => t.NumberOfPassengers).HasColumnName("NumberOfPassengers");
        }
    }

}