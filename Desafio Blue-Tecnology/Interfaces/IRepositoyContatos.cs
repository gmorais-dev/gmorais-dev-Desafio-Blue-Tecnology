using Desafio_Blue_Tecnology.Models;
using static Desafio_Blue_Tecnology.Interfaces.IRepositoyContatos;

namespace Desafio_Blue_Tecnology.Interfaces
{
    public interface IRepositoyContatos
    {
        public class RepositoryUser : IRepositoryUser
        {
            public void CreateUser(Contatos Contatos)
            {
                throw new NotImplementedException();
            }

            public void DeleteUser(Contatos Contatos)
            {
                throw new NotImplementedException();
            }

            public Task<IEnumerable<Contatos>> GetAllUser()
            {
                throw new NotImplementedException();
            }

            public Task<Contatos> GetOneUser(string Name)
            {
                throw new NotImplementedException();
            }

            public Task<bool> SavesChangesAsync()
            {
                throw new NotImplementedException();
            }

            public Task<Contatos> SearchOneUser(string email)
            {
                throw new NotImplementedException();
            }

            public void UpdateUser(Contatos Contatos)
            {
                throw new NotImplementedException();
            }
        }
    }
}
