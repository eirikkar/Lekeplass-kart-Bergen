using System.Diagnostics;
using Lekeplass_kart_Bergen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lekeplass_kart_Bergen.Controllers;

public class LekeplassController : Controller
{
    private readonly Lekeplass _lekeplass;
    private readonly HttpGetFile _httpGetFile;

    public LekeplassController()
    {
        _lekeplass = new Lekeplass();
        _httpGetFile = new HttpGetFile();
    }
}
