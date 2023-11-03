using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Producers;
using Manager.Implementation;
using Manager.Interfaces.IManager;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProducerController : ControllerBase
    {
        private readonly IProducerManager manager;

        public ProducerController(IProducerManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await manager.GetAllProducersAsync());
        }
    }
}