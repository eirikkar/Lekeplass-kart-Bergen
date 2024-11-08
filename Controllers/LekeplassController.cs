using Lekeplass_kart_Bergen.Models;
using Lekeplass_kart_Bergen.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lekeplass_kart_Bergen.Controllers;

[ApiController]
[Route("api/lekeplasser")]
public class LekeplassController : ControllerBase
{
    private readonly ILekeplassService _lekeplassService;
    private readonly IFileFetcher _fileFetcher;

    public LekeplassController(ILekeplassService lekeplassService, IFileFetcher fileFetcher)
    {
        _lekeplassService = lekeplassService;
        _fileFetcher = fileFetcher;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Lekeplass>>> GetAllLekeplasser()
    {
        var lekeplasser = _lekeplassService.GetLekeplasser(await _fileFetcher.GetCsvAsync());
        if (lekeplasser == null || !lekeplasser.Any())
        {
            return NotFound("No playgrounds found.");
        }
        return Ok(lekeplasser);
    }
}
