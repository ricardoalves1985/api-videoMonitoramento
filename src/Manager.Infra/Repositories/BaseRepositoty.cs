using System.Linq;
using System.Threading.Tasks;
using Manager.Domain.Entites;
using Manager.Infra.Interfaces;
using Manager.EntityFrameworkCore;


namespace Manager.Infra.Repositories{

   public class BaseRepository<T> : IBaseRepository<T> where T :Base{

       private readonly ManagerContext _context;


       public BaseRepository(ManagerContext context){
           _context = context;
       }

       public virtual async Task<T> Create(T obj){
           _context.Add(obj);
        await _context.SaveChangeAsync();

        return obj;


       }

       public virtual async Task<T> Update(T obj){
           _context.Entry(obj).State = EntityState.Modified;
        await _context.SaveChangeAsync();

        return obj;


       }
       public virtual async Task<T> Create(Int id){
           _context.Add(obj);
        await _context.SaveChangeAsync();

        return obj;
       }
        public virtual async Task<T> Remove(Long id){
            var obj = await Get(id);

            if(obj != null){

                _context.Remove(obj);
                await _context.SaveChangeAsync();

            }

        }

        public virtual async Task<T> Get(Long id){
            var obj = await _context.Set(T)
                                    .AsNoTracking()
                                    .Where(x=>x.Id == id)
                                    .ToListAsync();

            return obj.FirstOrDefault();
  

            
        }

        public virtual async Task<List<T>> Get(Long id){
                return await _context.Set<T>()
                                    .AsNoTracking()
                                    .ToListAsync();

        }


    }

}