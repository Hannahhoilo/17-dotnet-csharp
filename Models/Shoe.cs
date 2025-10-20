// using = importering 

using FiskAPI.Interfaces;

namespace FiskAPI.Models;

public class Shoe : IShoe
{
	public int Id { get; set; }

	public string ShoeModel { get; set; } = string.Empty;
	public int Price { get; set; }
	public bool InStock { get; set; }

}


	
