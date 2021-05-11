using Manager.Domain.Entites;
using Manager.Threading.Tasks;
using System.Collections.Generic;


namespace Manager.Infra.Interfaces{
    public interface IBaseRepository<T> where T : Base{
        
        Task<T> Create(T obj);

        Task<T> Update(T obj);

        Task<T> Remove(Long obj);

        Task<T> Get(long obj);

        Task<List<T>> Get(T obj);
        

    }
    

}