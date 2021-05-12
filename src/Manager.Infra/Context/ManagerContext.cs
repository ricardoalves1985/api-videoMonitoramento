using System.Collections.Generic;
using Manager.Domain.Entites;
using Manager.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;


namespace Manager.Infra.Context{

    public class ManagerContext : DbContext{
    
            public ManagerContext()
            { }

            public ManagerContext(DbContextOptions<ManagerContext> options) : base(options){}

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

                //optionsBuilder.UseMySql(Server=localhost;Database=serverapi;Uid=root;Pwd=12345678);
                
            }

            public virtual DbSet<Servidor> Servidores { get;set; }

          protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ServidorMap());
        }
    }
}