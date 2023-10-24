using Desafio_Blue_Tecnology.Models;

namespace Desafio_Blue_Tecnology.NovaPasta3
{
    public interface Services
    {
        Task<IEnumerable< Contatos>> GetAllUser();
        Task<Contatos> GetOneUser(int Numero);
        Task<Contatos> SearchOneUser(string email);
        void CreateUser(Contatos Contatos);
        void UpdateUser(String Numero, Contatos Contatos);
        void DeleteUser(String Numero, Contatos Contatos);
    }
}
