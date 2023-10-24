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
        [HttpGet]
       public async Task<IActionResult> Get()


       var Contatos = await this.services.GetAllUser();



    }








    