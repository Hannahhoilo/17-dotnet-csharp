namespace FiskAPI.Interfaces; // dett er exporten. skal hete navnet på prosjektet og mappen den ligger i 

interface IFish //interface er kontrakt om hva som minimum skal være med 
{
	int Id { get; set; }
	string Species { get; set; }
}
