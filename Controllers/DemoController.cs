using Microsoft.AspNetCore.Mvc;
namespace demo.controllers;

[ApiController]
[Route("[Controller]")]
public class DemoController : ControllerBase 
{
    [HttpGet]
    public string Demo()
    {
        return "demo";
    }
}