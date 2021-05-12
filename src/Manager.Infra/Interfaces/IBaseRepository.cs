using Manager.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base{
        
        Task<T> Create(T obj);

        Task<T> Update(T obj);

        Task<T> Remove(long obj);

        Task<T> Get(long obj);

        Task<List<T>> Get(T obj);
        

    }
    

}