public class Mago : Personaje
{
    public int Magia { get; set; }
    public Mago(string nombre, int vida, int fuerza, int magia)
    : base(nombre, vida, fuerza)
    {
        Magia = magia;
    }
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} lanza una bola de fuego ardiente!");
        int danoTotal = Fuerza + Magia;
        objetivo.RecibirDano(danoTotal);
    }
}