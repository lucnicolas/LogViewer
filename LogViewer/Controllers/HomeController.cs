using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LogViewer.Models;
using LogViewer.Repositories;

namespace LogViewer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ILogRepository _logRepository;

    public HomeController(ILogger<HomeController> logger, ILogRepository logRepository)
    {
        _logger = logger;
        _logRepository = logRepository;
        _logRepository.InitializeData();
    }

    [HttpGet]
    public IActionResult Index(Filters filters)
    {
        return View(_logRepository.GetAllFiltered(filters));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}