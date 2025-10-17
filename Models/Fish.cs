// importerer her med : using 

using FiskAPI.Interfaces;


/*En namespace i C# brukes til å organisere kode og unngå navnekollisjoner.
Den fungerer litt som en mappe eller pakke i Java.*/
namespace FiskAPI.Models;
//alle modell klasser er public 

// denne feilmedingen sier: 
public class Fish : IFish 
{
	public int Id { get; set; }
	public string Species { get; set; } = string.Empty;

}


/*
Model i sammenhenge med backend refererer til kjerneklasser til en bedrift
i praksisk betyr modelklassene for eks Ruter, (tog buss trikk) de har som kjerneinfor 
om trikker sjofører og tider. 
*/