using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Screenwrite;
using Manager.Interfaces.IManager;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScreenwriteController : ControllerBase
    {
        private readonly IScreenwriteManager manager;

        public ScreenwriteController(IScreenwriteManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await manager.GetAllScreenwriterAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await manager.GetScreenwriterByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(NewScreenwrite newScreenwrite)
        {
            var insertScreenwriter = await manager.InsertScreenwriterAsync(newScreenwrite);
            return CreatedAtAction(nameof(GetAll), new {id = insertScreenwriter.Id}, insertScreenwriter);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ScreenwriteUpdate screenwriteUpdate)
        {
            var updateScreenwriter = await manager.UpdateScreenwriterAsync(screenwriteUpdate);

            if (updateScreenwriter == null)
            {
                return NotFound();
            }

            return Ok(updateScreenwriter);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await manager.DeleteScreenwriterAsync(id);
            return NoContent();
        }
    }
}