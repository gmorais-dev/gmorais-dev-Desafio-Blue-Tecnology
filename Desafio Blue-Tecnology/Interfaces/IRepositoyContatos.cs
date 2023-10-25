using Desafio_Blue_Tecnology.Interfaces;
using Desafio_Blue_Tecnology.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio_Blue_Tecnology.Interfaces
{
    public interface IRepositoyContatos
    {
        void CreateUser(Contatos Contatos);
        void DeleteUser(Contatos Contatos);
        Task<IEnumerable<Contatos>> GetAllUser();
        Task<Contatos> GetOneUser(string Name);
        Task<bool> SavesChangesAsync();
        Task<Contatos> SearchOneUser(string email);
        void UpdateUser(Contatos Contatos);
    }
}

namespace Desafio_Blue_Tecnology.Services
{
    public class RepositoryContatos : IRepositoyContatos
    {
        private readonly ContatosContext context;

        public RepositoryContatos(ContatosContext context)
        {
            this.context = context;
        }

        public void CreateUser(Contatos Contatos)
        {
            this.context.Add(Contatos);
        }

        public void DeleteUser(Contatos Contatos)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contatos>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public async Task<Contatos> GetOneUser(string Name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SavesChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Contatos> SearchOneUser(string email)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Contatos Contatos)
        {
            throw new NotImplementedException();
        }
    }
}
