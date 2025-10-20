namespace FiskAPI.Interfaces;

interface IShoe
{
	int Id { get; set; }
	string ShoeModel { get; set; }
	int Price { get; set; }
	bool InStock { get; set; }
}
// masse sko 