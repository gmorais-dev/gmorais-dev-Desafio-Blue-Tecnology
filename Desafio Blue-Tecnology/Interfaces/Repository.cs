using Desafio_Blue_Tecnology.Models;

namespace Desafio_Blue_Tecnology.Interfaces

{   

    public interface Repository
    {
        Task<IEnumerable<Contatos>> GetAllUser();
        Task<Contatos> GetOneUser(String Name);
        Task<Contatos> SearchOneUser(string email);
        void CreateUser(Contatos Contatos);
        void UpdateUser(Contatos Contatos);
        void DeleteUser(Contatos Contatos);
        Task<bool> SavesChangesAsync();
    }
}
