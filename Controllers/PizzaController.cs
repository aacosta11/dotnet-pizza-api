using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }
    // GET all pizzas
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => 
        PizzaService.GetAll();
    
    // GET all pizzas by id
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);
        // if (pizza == null) 
        //     return NotFound();
        // return pizza;
        return pizza == null ? NotFound() : pizza;
    }
    // POST a pizza
    // PUT a pizza
    // DELETE a pizza
}