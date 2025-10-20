using FiskAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FiskAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class ShoeController : ControllerBase
{
	List<Shoe> shoe = new List<Shoe>
	{
		new Shoe { Id = 1, ShoeModel = "Converse", Price = 600, InStock = true },
		new Shoe { Id = 2, ShoeModel = "Summer Sandals", Price = 590, InStock = false },
		new Shoe { Id = 4, ShoeModel = "Winter Boots", Price = 1299, InStock = true }
	};
	[HttpGet] // endepunkt http://localohost:XXXX/shoe

	public List<Shoe> Get()
	{
		return shoe;
	}

	[HttpGet("{id}")] // http://localohost:XXXX/shoe/3

	public Shoe Get(int id)
	{
		Shoe? selectedShoe = shoe.Find(_shoe => _shoe.Id == id);
		return selectedShoe;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(shoe);
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var selectedShoe = shoe.Find(s => s.Id == id);
		if (selectedShoe == null)
			return NotFound($"Shoe with id {id} not dound!");
		return Ok(selectedShoe);
	}
// GET /fish/favouriteshoe
	[HttpGet("favouriteshoe")]

	public IActionResult FavouriteShoe()
	{
		var favShoe = shoe.Find(s => s.Id == 1);
		return Ok(new { Message = "HellO!", Shoe = favShoe });
	}
}
