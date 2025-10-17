using Microsoft.AspNetCore.Mvc;
using FiskAPI.Models;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection.Metadata.Ecma335;

namespace FiskAPI.Controllers;

[ApiController]
[Route("[controller]")]
// alle apikontrollere skal arve gra controllerbase
public class FishController : ControllerBase
{

	List<Fish> fish = new List<Fish>
	{

		new Fish { Id = 1, Species = "Makrell i tomat" },
		new Fish { Id = 2, Species = "Laks" },
		new Fish { Id = 3, Species = "Gullfisk" },
		new Fish { Id = 4, Species = "Torsk" }
	};

	[HttpGet] // endepunkt http://localohost:XXXX/fish
	public List<Fish> Get()
	{
		return fish;
	}

	[HttpGet("{id}")] // dette betyr at vi kommer til p ha samme endepunkt som http://localohost:XXXX/fish/3
	public Fish Get(int id)
	{
		Fish? selectedFish = fish.Find(_fish => _fish.Id == id);
		return selectedFish;
	}


	// GET /fish
	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(fish);
	}

	// GET /fish/{id}
	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var selectedFish = fish.Find(f => f.Id == id);
		if (selectedFish == null)
			return NotFound($"Fish with id {id} not found!");
		return Ok(selectedFish);

	}

	// GET /fish/favouritefish
	[HttpGet("favouritefish")]
	public IActionResult FavouriteFish()
	{
		var favFish = fish.Find(f => f.Id == 2);
		return Ok(new { Message = "Hello!", Fish = favFish });
	}
}



/*Mottar HTTP-forespørsler (GET, POST, PUT, DELETE)

Snakker med logikken i programmet (services, repositories)

Returnerer svar (f.eks. JSON-data) tilbake til klienten (frontend, Postman, etc.)



| Del av prosjektet | Rolle                                                    |
| ----------------- | -------------------------------------------------------- |
| **Controller**    | Håndterer HTTP-requests og returnerer svar               |
| **Model**         | Beskriver data (f.eks. `Fish`)                           |
| **Repository**    | Henter og lagrer data                                    |
| **Interface**     | Definerer “kontrakt” for hvordan repo/metoder skal se ut |
*/
