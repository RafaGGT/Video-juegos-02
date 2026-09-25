public class Guerrero : Personaje
{
    public int Armadura { get; set; }
    public Guerrero(string nombre, int vida, int fuerza, int armadura)
    : base(nombre, vida, fuerza)
    {
        Armadura = armadura;
    }
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} levanta su espada y da un golpe crítico!");
        int danoTotal = Fuerza + 5;
        objetivo.RecibirDano(danoTotal);
    }
}