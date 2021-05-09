using System.Threading.Tasks;
using SindOnibus.Domain;

namespace SindOnibus.Repository
{
    public interface ISindOnibusRepository
    {
        //Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangeAsync();

        Task<Cadastro[]> GetAllCadastroAsyncByNome(string Nome);
         Task<Cadastro[]> GetAllCadastroAsync();
          Task<Cadastro[]> GetAllCadastroAsyncById(int Id);
    }
}