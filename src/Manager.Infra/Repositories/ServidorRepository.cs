using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.Domain.Entities;
using Manager.Infra.Context;
using Manager.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Repositories{
    public class ServidorRepository : BaseRepository<Servidor>, IServidorRepository{
        private readonly ManagerContext _context;

        public ServidorRepository(ManagerContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Servidor> GetByNameServidor(string nameServido)
        {
            var servidor = await _context.Users
                                   .Where
                                   (
                                        x =>
                                            x.Servidor.ToLower() == nameServido.ToLower()
                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return servidor.FirstOrDefault();
        }

        public async Task<List<Servidor>> SearchyByNameServidor(string nameServido)
        {
            var allServidores = await _context.Users
                                   .Where
                                   (
                                        x =>
                                            x.Servidor.ToLower().Contains(nameServido.ToLower())
                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return allServidores;
        }

      /* public async Task<List<User>> SearchByName(string name)
        {
            var allUsers = await _context.Users
                                   .Where
                                   (
                                        x =>
                                            x.Name.ToLower().Contains(name.ToLower())
                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return allUsers;
        }*/
    }
}