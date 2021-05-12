using Manager.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infra.Mappings{
    public class ServidorMap : IEntityTypeConfiguration<Servidor>
    {
        

        public void Configure(EntityTypeBuilder<Servidor> builder)
        {
          
        
            builder.ToTable("servidorapi");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id)
                //.UseAutoIncrementColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.NameServidor)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(80)");

           
        }
    }
}