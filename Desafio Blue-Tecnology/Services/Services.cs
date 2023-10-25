using Desafio_Blue_Tecnology.Interfaces;
using Desafio_Blue_Tecnology.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Desafio_Blue_Tecnology.Interfaces.IRepositoyContatos;

namespace Desafio_Blue_Tecnology.Services
{
    public class Services : IServices
    {
        private readonly IRepositoryContatos repository;

        public Services(IRepositoryContatos repository)
        {
            this.repository = repository;
        }

        public Contatos CreateContatos(ContatosCreate ContatosCreate)
        {
            var novoContato = new Contatos
            {
                Nome = ContatosCreate.Nome,
                Telefone = ContatosCreate.Telefone,
            };

            repository.Add(novoContato);
            return novoContato;
        }

        public async Task<List<Contatos>> GetAllUser()
        {
            return await repository.GetAllContatos();
        }

        public async Task<Contatos> GetOneUser(string telefone)
        {
            return await repository.GetContatoByTelefone(telefone);
        }

        public void DeleteContato(Contatos Contatos)
        {
            repository.Remove(Contatos);
        }

        public Contatos UpdateContato(string name, ContatosUpdate ContatosUpdate)
        {
            var Contatos = repository.GetContatoByName(name);
            if (Contatos != null)
            {
                Contatos.Nome = ContatosUpdate.Nome;
                Contatos.Telefone = ContatosUpdate.Telefone;
                repository.Update(Contatos);
            }
            return Contatos;
        }
    }
}
