using Microsoft.AspNetCore.Mvc;
using escolaAPI.src.Service;

namespace escolaAPI.src.Controller;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly DataService _dataService;
    private readonly XmlService _xmlService;

    public HomeController(DataService dataService, XmlService xmlService)
    {
        _dataService = dataService;
        _xmlService = xmlService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var data = _dataService.GetDataAsync();
        var xmlData = _xmlService.TransformToXml(data);
        return Ok(xmlData);
    }
}
