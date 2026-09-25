public class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; protected set; }
    protected int Fuerza { get; set; }

    

    public Personaje(string nombre, int vida, int fuerza)
    {
        Nombre = nombre;
        Vida = vida;
        Fuerza = fuerza;
    }


    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} con un golpe básico.");
       
        objetivo.RecibirDano(Fuerza);
    }
    public void RecibirDano(int dano)
    {
        Vida -= dano;
        // Validamos que la vida no quede negativa
        if (Vida < 0) Vida = 0;
        Console.WriteLine($" -> {Nombre} recibe {dano} de daño. (Vida:{Vida})\n");
    }

    public void CurarVida(int cantidad)
    {
        Vida += cantidad;
    }
}