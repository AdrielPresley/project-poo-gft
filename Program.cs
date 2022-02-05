using project_poo_gft.src.Entities;
class Program
{
	static void Main(string[] args)

	{
		Characters player = new Characters("Leonidas", 90, "Guerreiro");
		Characters playertwo = new PlayerTwo("Jack", 90, "Atirador", "Rajada Furiosa");
		Characters playerthree = new PlayerThree("Asta", 90, "Feiticeiro", 2);

		System.Console.WriteLine(player.Attack());
		System.Console.WriteLine(playertwo.Attack());
		System.Console.WriteLine(playerthree.Attack());
	}

}