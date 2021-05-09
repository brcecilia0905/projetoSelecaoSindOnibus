using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SindOnibus.Domain;

namespace SindOnibus.Repository
{
    public class SindOnibusRepository : ISindOnibusRepository
    {
        public SindOnibusContext _context { get; }

        public SindOnibusRepository(SindOnibusContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        //metodos gerais.
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
                
        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        //Cadastro

        public async Task<Cadastro[]> GetAllCadastroAsync()
        {
            IQueryable<Cadastro> query = _context.Cadastros;

            
            return await query.ToArrayAsync();
                
        }

        public async Task<Cadastro[]> GetAllCadastroAsyncById(int Id)
        {
           IQueryable<Cadastro> query = _context.Cadastros;

            
            return await query.ToArrayAsync();
        }

        public async Task<Cadastro[]> GetAllCadastroAsyncByNome(string Nome)
        {
            IQueryable<Cadastro> query = _context.Cadastros;

            
            return await query.ToArrayAsync();
        }

        
    }
}