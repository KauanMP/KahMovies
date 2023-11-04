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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await manager.GetProducerByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(NewProducer newProducer)
        {
            var insertProducer = await manager.InsertProducerAsync(newProducer);
            return CreatedAtAction(nameof(GetAll), new { id = insertProducer.Id }, insertProducer);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProducerUpdate producerUpdate)
        {
            var updateProducer = await manager.UpdateProducerAsync(producerUpdate);

            if (updateProducer == null)
            {
                return NotFound();
            }

            return Ok(updateProducer);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await manager.DeleteProducerAsync(id);
            return NoContent();
        }
    }
}