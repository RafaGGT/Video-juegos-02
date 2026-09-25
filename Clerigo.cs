public class Clerigo : Personaje
{
    public int Voluntad { get; set; }
    private Random random = new Random();

    public Clerigo(string nombre, int vida, int fuerza, int voluntad)
        : base(nombre, vida, fuerza)
    {
        Voluntad = voluntad;
    }

    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} azota con su mayal!");
        int danoTotal = Fuerza;
        objetivo.RecibirDano(danoTotal);

        // 50% de probabilidad de curarse además del ataque
        int probabilidad = random.Next(0, 2); // 0 o 1
        if (probabilidad == 1)
        {
            Curar(this);
        }
    }

    public void Curar(Personaje personaje)
    {
        Console.WriteLine($"{Nombre} suplica por un milagro de curación por {Voluntad} de vida, vida actual ({Vida})");
        personaje.CurarVida(Voluntad);
    }
}