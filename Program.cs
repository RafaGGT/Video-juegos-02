bool jugarDeNuevo = true;

while (jugarDeNuevo)
{
    Console.WriteLine("=== INICIO DE LA BATALLA ===\n");

    Guerrero arthur = new Guerrero("Arthur el Valiente", 100, 15, 10);
    Mago merlin = new Mago("Merlín el Sabio", 70, 5, 20);
    Clerigo samarie = new Clerigo("Samarie la Santa", 80, 13, 20);

    Console.WriteLine("=== ELIGE TU PERSONAJE ===");
    Console.WriteLine("1. Arthur el Valiente");
    Console.WriteLine("2. Merlín el Sabio");
    Console.WriteLine("3. Samarie la Santa");

    if (!int.TryParse(Console.ReadLine(), out int opcion1))
    {
        Console.WriteLine("Entrada no válida");
        continue;
    }

    Personaje jugador;
    switch (opcion1)
    {
        case 1:
            jugador = arthur;
            Console.WriteLine("Has elegido a Arthur\n");
            break;

        case 2:
            jugador = merlin;
            Console.WriteLine("Has elegido a Merlín\n");
            break;

        case 3:
            jugador = samarie;
            Console.WriteLine("Has elegido a Samarie\n");
            break;

        default:
            Console.WriteLine("Opción no válida");
            continue;
    }

    Console.WriteLine("=== ELIGE A TU RIVAL ===");
    Console.WriteLine("1. Arthur el Valiente");
    Console.WriteLine("2. Merlín el Sabio");
    Console.WriteLine("3. Samarie la Santa");

    if (!int.TryParse(Console.ReadLine(), out int opcion2))
    {
        Console.WriteLine("Entrada no válida");
        continue;
    }

    Personaje enemigo;
    switch (opcion2)
    {
        case 1:
            enemigo = arthur;
            Console.WriteLine("Tu rival será Arthur\n");
            break;

        case 2:
            enemigo = merlin;
            Console.WriteLine("Tu rival será Merlín\n");
            break;

        case 3:
            enemigo = samarie;
            Console.WriteLine("Tu rival será Samarie\n");
            break;

        default:
            Console.WriteLine("Opción no válida");
            continue;
    }

    if (jugador == enemigo)
    {
        Console.WriteLine("No puedes elegir el mismo personaje como rival.");
        continue;
    }

    int ronda = 1;
    // Bucle del combate
    while (jugador.Vida > 0 && enemigo.Vida > 0)
    {
        Console.WriteLine($"--- RONDA {ronda} ---");

        // Turno 1
        jugador.Atacar(enemigo);
        if (enemigo.Vida <= 0) break;

        // Turno 2
        enemigo.Atacar(jugador);
        if (jugador.Vida <= 0) break;

        ronda++;
        Console.WriteLine("Presiona ENTER para la siguiente ronda...\n");
        Console.ReadLine();
    }

    Console.WriteLine("=== FIN DE LA BATALLA ===\n");

    // Resolución
    if (jugador.Vida > 0)
        Console.WriteLine($"¡{jugador.Nombre} es el vencedor!");
    else
        Console.WriteLine($"¡{enemigo.Nombre} es el vencedor!");

    // Preguntar si quiere jugar de nuevo
    Console.WriteLine("\n¿Quieres jugar de nuevo? (S/N)");
    string? respuesta = Console.ReadLine();
    jugarDeNuevo = respuesta != null && respuesta.Trim().ToUpper() == "S";
}

Console.WriteLine("\n¡Gracias por jugar!");