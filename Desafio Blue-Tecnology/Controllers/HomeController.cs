using Desafio_Blue_Tecnology.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Desafio_Blue_Tecnology.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserServices services;
        private readonly IRepositoryUser repository;

        private readonly IMapper mapper;

        public UserController(IUserServices services, IRepositoryUser repository)
        {
            this.services = services;
            this.repository = repository;
            this.mapper = mapper;

        }
    }
    
        
      
        



    