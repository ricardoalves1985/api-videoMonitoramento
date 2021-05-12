
using System.Collections.Generic;
using System.Threading.Tasks;
using Manager.Domain.Entites;

namespace Manager.Infra.Interfaces{
    public interface IServidorRepository : IBaseRepository<Servidor>{

        Task<Servidor> GetByID(int id);

        Task<List<Servidor>> SearchByName(string nameservidor);


    }

}