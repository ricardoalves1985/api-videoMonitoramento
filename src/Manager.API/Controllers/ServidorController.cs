using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manager.Core.Exceptions;
using Manager.API.Controllers;
using Manager.API.ViewModes;
using System;
using Manager.Services.Interfaces;

namespace Manager.API.Controllers
{

    [ApiController]
    public class ServidorController : ControllerBase{

        private readonly IMapper _mapper;
        private readonly IServidorService _servidorService;

        public ServidorController(IMapper mapper, IServidorService servidorService)
        {
            _mapper = mapper;
            _servidorService = servidorService;
        }

        [HttpPost]
        [Route("api/server")] //Cria um servidor
        public async Task<IActionResult> Create([FromBody] CreateServidorViewModel servidorViewModel){
            try
            {
                return Ok();
            }
            catch(DomainException ex)
            {
                return BadRequest();
            }
            catch(Exception)
            {
                    return StatusCode(500,"Erro");
            }
        }

    }

}