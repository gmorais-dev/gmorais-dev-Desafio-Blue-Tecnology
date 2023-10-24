using Desafio_Blue_Tecnology.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace Desafio_Blue_Tecnology.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private object services;
        private object repository;

        [HttpGet]
        public async Task<IActionResult> Get(Contatos)
        {
            var Contatos = await this.service.GetOneContatos(String Numero)
                 return Contatos != null
                ? Ok(Contatos) : BadRequest(" Contato não encontrado");
                
        }

        [HttpPut("{Numero}")]
        public async Task<IActionResult> Put(String name, String Telefone, String email)
        {
            var Contatos = await this.services.GetOneContatos(name);
            return await this.repository.SavesChangesAsync()
      ? Ok(Contatos)
      : BadRequest("Erro ao atualizar o Contato");
        }

        [HttpGet("/Busca")]
        public async Task<IActionResult> Get([FromQuery] string email)
        {
            var Contatos = await this.services.SearchOneUser(email);
            return Ok(Contatos);

        }





    }

}








