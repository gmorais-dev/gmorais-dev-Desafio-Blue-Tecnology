using Desafio_Blue_Tecnology.Interfaces;
using Desafio_Blue_Tecnology.Models;
using Desafio_Blue_Tecnology.NovaPasta3;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static Desafio_Blue_Tecnology.Interfaces.IRepositoyContatos;

namespace Desafio_Blue_Tecnology.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IServices services;
        private readonly IRepositoryContatos repository;

        public UserController(IServices services, IRepositoryContatos repository)
        {
            this.services = services;
            this.repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ContatosCreate ContatosCreate)
        {
            var ContatosPub = this.services.CreateContatos(ContatosCreate);
            return await this.repository.SaveChangesAsync()
                ? Ok(ContatosPub)
                : BadRequest("Erro ao criar Contato");
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Contatos = await services.GetAllUser();
            return Ok(Contatos);
        }

        [HttpGet("{telefone}")]
        public async Task<IActionResult> GetOne(string telefone)
        {
            var Contatos = await this.services.GetOneUser(telefone);
            return Contatos != null
                ? Ok(Contatos)
                : NotFound("Contato não encontrado");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string name)
        {
            var excluicc = await this.services.GetOneUser(name);
            this.services.DeleteContato(excluicc);
            return await this.repository.SaveChangesAsync()
                ? Ok("Contato removido com sucesso")
                : BadRequest("Erro ao remover o contato");
        }

        [HttpPut("{name}")]
        public async Task<IActionResult> Put(string name, ContatosUpdate ContatosUpdate)
        {
            var Contatos = await this.services.GetOneUser(name);
            var uptadeContato = this.services.UpdateContato(name, ContatosUpdate);
            return await this.repository.SaveChangesAsync()
                ? Ok(uptadeContato)
                : BadRequest("Erro ao atualizar o contato");
        }
    }
}
