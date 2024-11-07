using System.Collections.Generic;
using Lekeplass_kart_Bergen.Models;
using Lekeplass_kart_Bergen.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lekeplass_kart_Bergen.Controllers
{
    [ApiController]
    [Route("api/lekeplasser")]
    public class LekeplassController : ControllerBase
    {
        private readonly ILekeplassService _lekeplassService;

        public LekeplassController(ILekeplassService lekeplassService)
        {
            _lekeplassService = lekeplassService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Lekeplass>> GetAllLekeplasser()
        {
            var lekeplasser = _lekeplassService.GetLekeplasser();
            if (lekeplasser == null || !lekeplasser.Any())
            {
                return NotFound("No playgrounds found.");
            }
            return Ok(lekeplasser);
        }
    }
}
